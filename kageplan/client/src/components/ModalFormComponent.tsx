import react, { Dispatch, SetStateAction } from 'react';
import '../App.scss';
import { EventTime, Event } from '../interfaces';
import CustomModal from './CustomModal';

interface EventProps {
  isOpen: boolean;
  title: string;
  selectedEvent: Event;
  setSelectedEvent: Dispatch<SetStateAction<Event>>;
  eventTime: EventTime;
  setEventTime: Dispatch<SetStateAction<EventTime>>;
  onClick: (e: react.FormEvent<HTMLFormElement>) => void;
  onRequestClose: (e: React.MouseEvent<Element, MouseEvent> | React.KeyboardEvent<Element>) => void;
  children?: React.ReactNode;
}

const ModalFormComponent = ({
  isOpen,
  title,
  selectedEvent: { cakeType, cakeOccasion },
  setSelectedEvent,
  eventTime: { startTime },
  setEventTime,
  onClick,
  onRequestClose,
}: EventProps) => {
  const handleSelectedEventChange = (e: react.ChangeEvent<HTMLInputElement>) => {
    setSelectedEvent((prevState) => ({ ...prevState, [e.target.name]: e.target.value }));
  };

  const handleEventTimeChange = (e: react.ChangeEvent<HTMLInputElement>) => {
    setEventTime((prevState) => ({ ...prevState, [e.target.name]: e.target.value }));
  };

  return (
    <CustomModal isOpen={isOpen} onRequestClose={onRequestClose}>
      <main className="form-container">
        <form
          autoComplete="off"
          spellCheck="false"
          onSubmit={(e) => {
            e.preventDefault();
            onClick(e);
          }}
        >
          <h3 className="form-container__title">{title}</h3>
          <hr />
          <div className="event-form">
            <label htmlFor="starttime">Start time: </label>
            <input
              id="starttime"
              type="time"
              name="startTime"
              value={startTime}
              // onChange={(e) => setEventTime((prevState) => ({ ...prevState, startTime: e.target.value }))}
              onChange={handleEventTimeChange}
            />

            <label>Occasion:</label>
            <input
              autoFocus={true}
              type="text"
              placeholder="Birthday...?"
              name="cakeOccasion"
              value={cakeOccasion}
              // onChange={(e) => setSelectedEvent((prevState) => ({ ...prevState, cakeOccasion: e.target.value }))}
              onChange={handleSelectedEventChange}
            />

            <label>Type of cake:</label>
            <input
              type="text"
              placeholder="Chocolate...?"
              name="cakeType"
              value={cakeType}
              // onChange={(e) => setSelectedEvent((prevState) => ({ ...prevState, cakeType: e.target.value }))}
              onChange={handleSelectedEventChange}
            />
          </div>
          <div className="btn-container">
            <button className="btn btn--cancel btn--solidborder" onClick={onRequestClose}>
              Cancel
            </button>
            <input className="btn btn--standard btn--solidborder" type="submit" value="Submit" />
          </div>
        </form>
      </main>
    </CustomModal>
  );
};

ModalFormComponent.defaultProps = {
  title: '',
};

export default ModalFormComponent;
