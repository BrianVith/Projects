import '../App.scss';
import { EventContentArg } from '@fullcalendar/react';
import { PadTo2Digits } from '../util/handleTimeAdjustment';

const CustomDiplayEvent = (e: EventContentArg) => {
  const username = e.event._def.extendedProps.username;
  const start = e.event.start;

  return (
    <div className="calendar-display">
      <div className="">
        {PadTo2Digits(start?.getHours())}:{PadTo2Digits(start?.getMinutes())}
      </div>
      <div>{username}</div>
    </div>
  );
};

export default CustomDiplayEvent;
