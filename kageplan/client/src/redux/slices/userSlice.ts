import { createSlice, PayloadAction } from '@reduxjs/toolkit';

interface userState {
  username: string;
  userId: number | null;
}

const initialState: userState = {
  username: '',
  userId: null,
};

export const userSlice = createSlice({
  name: 'user',
  initialState,
  reducers: {
    setUsername: (state, action: PayloadAction<string>) => {
      state.username = action.payload;
    },
    unsetUsername: (state) => {
      state.username = 'anonymous';
    },
    setUserId: (state, action: PayloadAction<number | null>) => {
      state.userId = action.payload;
    },
    unsetUserId: (state) => {
      state.userId = null;
    },
  },
});

export const { setUsername, unsetUsername, setUserId, unsetUserId } = userSlice.actions;

export default userSlice.reducer;
