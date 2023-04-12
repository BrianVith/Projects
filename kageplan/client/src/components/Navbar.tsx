import { useSelector, useDispatch } from 'react-redux';
import { NavLink } from 'react-router-dom';
import { RootState } from '../redux/store';
import { onLogout } from '../api/auth';
import { unauthenticateUser } from '../redux/slices/authSlice';
import { unsetUserId, unsetUsername } from '../redux/slices/userSlice';

const Navbar = () => {
  const dispatch = useDispatch();
  const { isAuth } = useSelector((state: RootState) => state.auth);
  const { username } = useSelector((state: RootState) => state.user);

  const onClick = async () => {
    try {
      await onLogout();
      dispatch(unauthenticateUser());
      dispatch(unsetUsername());
      dispatch(unsetUserId());
      localStorage.removeItem('isAuth');
    } catch (err) {
      if (err instanceof Error) {
        console.log(err.message);
      }
    }
  };

  return (
    <nav className="nav">
      <NavLink to="/">Home</NavLink>

      {isAuth === true ? (
        <>
          <span>{username}</span>
          <button onClick={onClick}>Logout</button>
        </>
      ) : (
        <ul>
          <li>
            <NavLink to="/login">Login</NavLink>
          </li>
        </ul>
      )}
    </nav>
  );
};

export default Navbar;
