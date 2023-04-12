import { useState } from 'react';
import { onRegistration } from '../api/auth';
import Layout from '../components/Layout';

const Register = () => {
  type ValueType = string;
  interface FormValues {
    name: ValueType;
    email: ValueType;
    password: ValueType;
    confirmPassword: ValueType;
    registerCode: ValueType;
  }

  const initialValues: FormValues = {
    name: '',
    email: '',
    password: '',
    confirmPassword: '',
    registerCode: '',
  };

  const [values, setValues] = useState(initialValues);
  const [error, setError] = useState('');
  const [success, setSuccess] = useState('');

  const onChange: React.ChangeEventHandler<HTMLInputElement> = (e) => {
    setValues({ ...values, [e.target.name]: e.target.value });
  };

  const onSubmit: React.FormEventHandler<HTMLFormElement> = async (e) => {
    e.preventDefault();

    try {
      const { data } = await onRegistration(values);
      setError('');
      setSuccess(data.message);
      setValues(initialValues);
    } catch (err: any) {
      setError(err.response.data.errors[0].msg);
      setSuccess('');
    }
  };

  return (
    <Layout>
      <h1>Register</h1>
      <section className="auth-container">
        <form autoComplete="off" onSubmit={(e) => onSubmit(e)}>
          <div>
            <label htmlFor="name">Username</label>
            <input
              onChange={onChange}
              type="name"
              id="name"
              name="name"
              value={values.name}
              placeholder="username"
              autoComplete="off"
              autoFocus
              required
            />
          </div>

          <div>
            <label htmlFor="email">Email address</label>
            <input
              onChange={onChange}
              type="email"
              id="email"
              name="email"
              value={values.email}
              placeholder="xyz@jfmedier.dk"
              required
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
              placeholder="password"
              autoComplete="new-password"
              required
            />
          </div>

          <div>
            <label htmlFor="password">Confirm Password</label>
            <input
              onChange={onChange}
              type="password"
              value={values.confirmPassword}
              id="confirmPassword"
              name="confirmPassword"
              placeholder="confirm password"
              autoComplete="new-password"
              required
            />
          </div>

          <div>
            <label htmlFor="password">Register Code</label>
            <input
              onChange={onChange}
              type="password"
              value={values.registerCode}
              id="registerCode"
              name="registerCode"
              placeholder="register code"
              autoComplete="new-password"
              required
            />
          </div>

          <button type="submit" className="btn btn--standard">
            Register
          </button>
          <div style={{ color: 'red', margin: '10px 0' }}>{error}</div>
          <div style={{ color: 'green', margin: '10px 0' }}>{success}</div>
        </form>
      </section>
    </Layout>
  );
};

export default Register;
