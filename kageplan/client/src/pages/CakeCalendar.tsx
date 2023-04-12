import { useEffect, useState } from 'react';
import FullCalendar, { DateSelectArg, EventClickArg } from '@fullcalendar/react'; // must go before plugins
import interactionPlugin from '@fullcalendar/interaction';
import dayGridPlugin from '@fullcalendar/daygrid'; // a plugin!
import timeGridPlugin from '@fullcalendar/timegrid';
import ModalFormComponent from '../components/ModalFormComponent';
import CustomUserDisplay from '../components/CustomUserDisplay';
import ShowEventComponent from '../components/ShowEventComponent';
import Layout from '../components/Layout';
import { Event } from '../interfaces';
import { initialEventState, initialEventTime } from '../initialState';
import { GetAllEvents, AddEvent, DeleteEvent, EditEvent } from '../controllers/cakeController';
import { useSelector, useDispatch } from 'react-redux';
import { authorizeUser } from '../api/auth';
import { unauthenticateUser } from '../redux/slices/authSlice';
import { setUsername, setUserId, unsetUsername, unsetUserId } from '../redux/slices/userSlice';
import { RootState } from '../redux/store';
import { AddTimeToEvent, ExtractTimeFromEvent } from '../util/handleTimeAdjustment';
import '../App.scss';

const CakeCalender = () => {
  const { isAuth } = useSelector((state: RootState) => state.auth);
  const { username, userId } = useSelector((state: RootState) => state.user);
  const [toggleEditModal, setToggleEditModal] = useState(false);
  const [toggleShowEventModal, setToggleShowEventModal] = useState(false);
  const [toggleAddEventModal, setToggleAddEventModal] = useState(false);
  const [selectedEvent, setSelectedEvent] = useState<Event>(initialEventState);
  const [allEvents, setAllEvents] = useState<Event[]>([]);
  const [eventTime, setEventTime] = useState(initialEventTime);
  const dispatch = useDispatch();

  const Authorize = async () => {
    try {
      const { data } = await authorizeUser();
      //setUser({ ...user, username: data.username, userId: data.user_id });
      //abstraction layer
      dispatch(setUsername(data.username));
      dispatch(setUserId(data.user_id));
      //hertil
    } catch (err) {
      if (err instanceof Error) {
        console.log(err.message);
        //setUser({ ...user, username: 'anonymous' });
        // læg i api metode
        dispatch(unsetUsername());
        dispatch(unsetUserId());
        dispatch(unauthenticateUser());
        localStorage.removeItem('isAuth');
        // hertil
      }
    }
  };

  //edit event
  const HandleEditEvent = async () => {
    const edited = AddTimeToEvent(selectedEvent, eventTime);
    await EditEvent(edited);
    setToggleEditModal(false);
    HandleGetEvents();
  };

  //delete event
  const HandleDeleteEvent = async () => {
    await DeleteEvent(selectedEvent);
    setToggleShowEventModal(!toggleShowEventModal);
    setAllEvents(allEvents.filter((item) => item !== selectedEvent));
  };

  //add event
  const HandleAddEvent = async () => {
    const newEvent = AddTimeToEvent(selectedEvent, eventTime);
    const addedEvent = await AddEvent(newEvent);
    setToggleAddEventModal(false);
    setAllEvents([...allEvents, addedEvent]);
  };

  //get all events
  const HandleGetEvents = async () => {
    const events = await GetAllEvents();
    setAllEvents(events);
  };

  const OnCloseModal = () => {
    setSelectedEvent(initialEventState);
    setEventTime(initialEventTime);
  };

  const OpenEditModal = () => {
    setToggleShowEventModal(false);
    setToggleEditModal(true);
  };

  const OnSelectEmptySlot = (arg: DateSelectArg) => {
    const end = arg.end;

    // prevents and extra day (calendar default)
    end.setDate(end.getDate() - 1);

    setSelectedEvent({
      ...selectedEvent,
      username,
      userId,
      start: arg.start,
      end: arg.end,
    });

    setToggleAddEventModal(!toggleAddEventModal);
  };

  const OnSelectEvent = (arg: EventClickArg) => {
    const { cakeId } = arg.event._def.extendedProps;
    const selected = allEvents.filter((event) => event.cakeId === cakeId)[0];
    setSelectedEvent(selected);

    const extractedEventTime = ExtractTimeFromEvent(selected);
    setEventTime(extractedEventTime);
    setToggleShowEventModal(!toggleShowEventModal);
  };

  useEffect(() => {
    Authorize();
  }, [isAuth]);

  useEffect(() => {
    HandleGetEvents();
  }, []);

  useEffect(() => {
    setSelectedEvent(initialEventState);
    setEventTime(initialEventTime);
  }, [allEvents]);

  return (
    <Layout>
      <h2>Cake Calendar</h2>
      <main className="calendar-view">
        <FullCalendar
          height="auto"
          selectable
          plugins={[interactionPlugin, dayGridPlugin, timeGridPlugin]}
          headerToolbar={{
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay',
          }}
          initialView="dayGridMonth"
          select={OnSelectEmptySlot}
          eventClick={OnSelectEvent}
          events={allEvents}
          eventContent={CustomUserDisplay}
          weekends={false}
          editable={false}
          longPressDelay={1}
          selectLongPressDelay={1}
          locale={'da'}
        />
      </main>

      <ShowEventComponent
        isOpen={toggleShowEventModal}
        selectedEvent={selectedEvent}
        handleDeleteEvent={HandleDeleteEvent}
        OpenEditModal={OpenEditModal}
        onRequestClose={() => {
          setToggleShowEventModal(false);
          OnCloseModal();
        }}
      />

      <ModalFormComponent
        title="Add Event"
        isOpen={toggleAddEventModal}
        onClick={HandleAddEvent}
        selectedEvent={selectedEvent}
        setSelectedEvent={setSelectedEvent}
        eventTime={eventTime}
        setEventTime={setEventTime}
        onRequestClose={() => {
          setToggleAddEventModal(false);
          OnCloseModal();
        }}
      />

      <ModalFormComponent
        title="Edit Event"
        isOpen={toggleEditModal}
        onClick={HandleEditEvent}
        selectedEvent={selectedEvent}
        setSelectedEvent={setSelectedEvent}
        eventTime={eventTime}
        setEventTime={setEventTime}
        onRequestClose={() => {
          setToggleEditModal(false);
          OnCloseModal();
        }}
      />
    </Layout>
  );
};

export default CakeCalender;
