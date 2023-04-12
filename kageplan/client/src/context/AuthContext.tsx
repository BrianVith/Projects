// import { createContext, useState, Dispatch, SetStateAction } from 'react';
// import { User, Event } from '../interfaces/Event';

// interface authProps {
//   children?: React.ReactNode;
// }

// // interface IAuth {
// //   auth: boolean;
// //   selectedEvent: Event;
// // }

// export const initialUserState: User = {
//   userId: null,
//   username: '',
// };

// export const initialEventState: Event = {
//   ...initialUserState,
//   cakeId: null,
//   cakeType: '',
//   cakeOccasion: '',
//   start: new Date(),
//   end: new Date(),
// };

// type stateContextType = {
//   selectedEvent: Event;
//   setSelectedEvent: Dispatch<SetStateAction<Event>>;
// };

// const initialStateContext = {
//   selectedEvent: initialEventState,
//   setSelectedEvent: () => {},
// };

// const AuthContext = createContext<stateContextType>(initialStateContext);

// export const AuthProvider = ({ children }: authProps) => {
//   const [selectedEvent, setSelectedEvent] = useState<Event>(initialEventState);

//   return <AuthContext.Provider value={{ selectedEvent, setSelectedEvent }}>{children}</AuthContext.Provider>;
// };

// export default AuthContext;
export {};
