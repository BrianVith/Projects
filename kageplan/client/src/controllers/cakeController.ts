import { initialEventState } from '../initialState';
import { Event } from '../interfaces';
const SERVER_URL = process.env.REACT_APP_SERVER_URL;

export const GetAllEvents = async () => {
  let allEventArray: Event[] = [];
  try {
    const response = await fetch(`${SERVER_URL}/api/cakes`, {
      method: 'GET',
      credentials: 'include',
      headers: { 'Content-Type': 'application/json' },
    });

    const jsonData = await response.json();

    // ** mapper data i Event til at være i string format i stedet for Date
    // Dette gør at jsonData ikke automatisk bliver kørt gennem toISOString() -> hvilket er
    // positivt da den roder med timezone og sætter tiden til UTC ... dvs. sletter vores 2+ GMT timer
    // så tiden altid er 2 timer bagud **

    allEventArray = jsonData.map((item: Record<string, never>): Event => {
      const start = new Date(item.start_date);
      const end = new Date(item.end_date);
      start.setMinutes(start.getMinutes() - start.getTimezoneOffset());
      end.setMinutes(end.getMinutes() - end.getTimezoneOffset());

      return {
        cakeId: item.cake_id,
        userId: item.user_id,
        username: item.user_name,
        cakeType: item.cake_type,
        cakeOccasion: item.cake_occasion,
        start,
        end,
      };
    });
  } catch (err) {
    if (err instanceof Error) {
      console.log(err.message);
    }
  }
  return allEventArray;
};

export const AddEvent = async (newEvent: Event) => {
  let addedEvent = initialEventState;
  try {
    const body = newEvent;

    const response = await fetch(`${SERVER_URL}/api/cakes`, {
      method: 'POST',
      credentials: 'include',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(body),
    });
    const jsonData = await response.json();

    const start = new Date(jsonData.start_date);
    const end = new Date(jsonData.end_date);
    start.setMinutes(start.getMinutes() - start.getTimezoneOffset());
    end.setMinutes(end.getMinutes() - end.getTimezoneOffset());

    addedEvent = {
      cakeId: jsonData.cake_id,
      userId: jsonData.user_id,
      username: newEvent.username,
      cakeType: jsonData.cake_type,
      cakeOccasion: jsonData.cake_occasion,
      start,
      end,
    };
  } catch (err) {
    if (err instanceof Error) {
      console.error(err.message);
    }
  }
  return addedEvent;
};

export const DeleteEvent = async (selectedEvent: Event) => {
  try {
    await fetch(`${SERVER_URL}/api/cakes/${selectedEvent?.cakeId}`, {
      method: 'DELETE',
      credentials: 'include',
      headers: { 'Content-Type': 'application/json' },
    });
  } catch (err) {
    if (err instanceof Error) {
      console.error(err.message);
    }
  }
};

export const EditEvent = async (selectedEvent: Event) => {
  let editedEvent = initialEventState;
  try {
    const body = selectedEvent;
    const response = await fetch(`${SERVER_URL}/api/cakes/${selectedEvent?.cakeId}`, {
      method: 'PATCH',
      credentials: 'include',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(body),
    });
    const jsonData = await response.json();

    editedEvent = {
      cakeId: jsonData.cake_id,
      userId: jsonData.user_id,
      username: selectedEvent.username,
      cakeType: jsonData.cake_type,
      cakeOccasion: jsonData.cake_occasion,
      start: new Date(jsonData.start_date),
      end: new Date(jsonData.end_date),
    };
  } catch (err) {
    if (err instanceof Error) {
      console.error(err.message);
    }
  }
  return editedEvent;
};
