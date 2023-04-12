//import { EventInput } from '@fullcalendar/react';

export interface EventTime {
  startTime: string;
  endTime: string;
}

export interface Event {
  userId: number | null;
  username: string;
  cakeId: number | null;
  cakeType: string;
  cakeOccasion: string;
  start: Date;
  end: Date;
  //children?: React.ReactNode;
}

// export interface CustomEvent extends EventInput {
//   extendedProps?: Event;
// }
