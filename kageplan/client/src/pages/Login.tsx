import { useState } from 'react';
import { onLogin } from '../api/auth';
import Layout from '../components/Layout';
import { useDispatch } from 'react-redux';
import { authenticateUser } from '../redux/slices/authSlice';

type ValueType = string;
interface FormValues {
  email: ValueType;
  password: ValueType;
}

const initialValues: FormValues = {
  email: '',
  password: '',
};

const Login = () => {
  const [values, setValues] = useState(initialValues);
  const [error, setError] = useState(false);

  const onChange: React.ChangeEventHandler<HTMLInputElement> = (e) => {
    setValues({ ...values, [e.target.name]: e.target.value });
  };

  const dispatch = useDispatch();
  const onSubmit: React.FormEventHandler<HTMLFormElement> = async (e) => {
    e.preventDefault();

    try {
      await onLogin(values);
      dispatch(authenticateUser());
      localStorage.setItem('isAuth', 'true');
      setValues(initialValues);
    } catch (err: any) {
      console.log(err.response.data.errors[0].msg);
      setError(err.response.data.errors[0].msg);
    }
  };

  return (
    <Layout>
      <h1>Login</h1>
      <section className="auth-container">
        <form onSubmit={onSubmit}>
          <div>
            <label htmlFor="email">Email address</label>
            <input
              onChange={onChange}
              type="email"
              id="email"
              name="email"
              value={values.email}
              placeholder="test@gmail.com"
              required
              autoFocus
            />
          </div>

          <div>
            <label htmlFor="password">Password</label>
            <input
              onChange={onChange}
              type="password"
              value={values.password}
              id="password"
              name="password"
              placeholder="passwod"
              required
            />
          </div>

          <button type="submit" className="btn btn--standard">
            Login
          </button>
          <div style={{ color: 'red', margin: '10px 0' }}>{error}</div>
        </form>
      </section>
    </Layout>
  );
};

export default Login;
