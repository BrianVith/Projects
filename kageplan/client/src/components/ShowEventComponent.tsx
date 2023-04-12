import { Event } from '../interfaces';
import { PadTo2Digits } from '../util/handleTimeAdjustment';
import { useSelector } from 'react-redux';
import { RootState } from '../redux/store';
import CustomModal from './CustomModal';

// *** Use EventProp instead as parameters? Best practice? ***
// const ShowEventComponent = ({ selectedEvent:{...} }: { selectedEvent: Event }) => { ... }
type EventProps = {
  isOpen: boolean;
  selectedEvent: Event;
  onRequestClose: (e: React.MouseEvent<Element, MouseEvent> | React.KeyboardEvent<Element>) => void;
  handleDeleteEvent: () => void;
  OpenEditModal: () => void;
};

const ShowEventComponent = ({
  isOpen,
  selectedEvent,
  onRequestClose,
  handleDeleteEvent,
  OpenEditModal,
}: EventProps) => {
  const { start, username, cakeType, cakeOccasion } = selectedEvent;
  const { isAuth } = useSelector((state: RootState) => state.auth);
  const { userId } = useSelector((state: RootState) => state.user);

  return (
    <CustomModal isOpen={isOpen} onRequestClose={onRequestClose}>
      <div className="event-component">
        {username && <div className="user">{username}</div>}
        <hr />
        <div>{start && start?.toLocaleDateString()}</div>
        {start && (
          <span>
            kl. {PadTo2Digits(start.getHours())}:{PadTo2Digits(start.getMinutes())}
          </span>
        )}
        {(cakeType || cakeOccasion) && <hr />}
        <div className="cake-event">
          {cakeOccasion && (
            <div>
              <b>Occasion:</b> {cakeOccasion}
            </div>
          )}
          {cakeType && (
            <div>
              <b>Cake:</b> {cakeType}
            </div>
          )}
        </div>
      </div>

      {isAuth && selectedEvent.userId === userId && (
        <div className="btn-container">
          <button className="btn btn--red" onClick={handleDeleteEvent}>
            Delete
          </button>
          <button className="btn btn--standard" onClick={OpenEditModal}>
            Edit
          </button>
        </div>
      )}
      <button className="btn btn--cancel" onClick={onRequestClose}>
        Cancel
      </button>
    </CustomModal>
  );
};

export default ShowEventComponent;
