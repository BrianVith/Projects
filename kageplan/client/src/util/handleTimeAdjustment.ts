import { Event, EventTime } from '../interfaces';
import moment from 'moment';

export const ExtractTimeFromEvent = (event: Event): EventTime => {
  if (event.start !== null && event.end !== null) {
    const startTime = PadTo2Digits(event.start?.getHours()) + ':' + PadTo2Digits(event.start?.getMinutes());
    const endTime = PadTo2Digits(event.end?.getHours()) + ':' + PadTo2Digits(event.end?.getMinutes());

    const eventTime: EventTime = {
      startTime,
      endTime,
    };

    return eventTime;
  }

  return { startTime: '00:00', endTime: '00:00' };
};

export const AddTimeToEvent = (event: Event, eventTime: EventTime): Event => {
  const dateStart = CombineDateAndTime(event.start, eventTime.startTime);
  let dateEnd = CombineDateAndTime(event.end, eventTime.endTime);

  // changed added since we didn't need endtime anymore
  dateEnd.setHours(dateStart.getHours() + 2);

  const addedTime: Event = {
    ...event,
    start: dateStart,
    end: dateEnd,
  };

  return addedTime;
};

export const PadTo2Digits = (number: number | undefined): string | undefined => {
  if (number !== undefined) return number.toString().padStart(2, '0');
};

const CombineDateAndTime = (date: Date, time: string): Date => {
  if (date !== null) {
    const month = date.getMonth(); // to get correct month in YY-MM-DD format
    const dateString = `${date.getFullYear().toString()}:${month + 1}:${date.getDate()}`;
    //moment datetime obj
    const dateTime = moment(dateString + ' ' + time, 'YYYY-MM-DD HH:mm');
    //format you wanted
    const formatedDateTime = dateTime.format('YYYY-MM-DD HH:mm');
    //output
    return new Date(formatedDateTime);
  }
  return new Date();
};
