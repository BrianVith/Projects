import { Event, EventTime } from '../interfaces';

export const initialEventState: Event = {
  userId: null,
  cakeId: null,
  username: '',
  cakeType: '',
  cakeOccasion: '',
  start: new Date(),
  end: new Date(),
};

export const initialEventTime: EventTime = {
  startTime: '09:00',
  endTime: '10:00',
};
