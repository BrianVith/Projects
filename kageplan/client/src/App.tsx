import { Fragment } from 'react';
import './App.scss';
import { BrowserRouter, Routes, Navigate, Route, Outlet } from 'react-router-dom';

import CakeCalendar from './pages/CakeCalendar';
import Login from './pages/Login';
import Register from './pages/Register';
import { useSelector } from 'react-redux';
import { RootState } from './redux/store';

const App = () => {
  const PrivateRoute = () => {
    const { isAuth } = useSelector((state: RootState) => state.auth);
    return <Fragment>{isAuth ? <Outlet /> : <Navigate to="/login" />}</Fragment>;
  };

  const RestrictedRoutes = () => {
    const { isAuth } = useSelector((state: RootState) => state.auth);
    return <Fragment>{!isAuth ? <Outlet /> : <Navigate to="/" />}</Fragment>;
  };

  return (
    <BrowserRouter>
      <Routes>
        <Route element={<PrivateRoute />}>
          <Route path="/" element={<CakeCalendar />} />
        </Route>
        <Route element={<RestrictedRoutes />}>
          <Route path="/register" element={<Register />} />
          <Route path="/login" element={<Login />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
};

export default App;
