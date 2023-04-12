import axios from 'axios';
axios.defaults.withCredentials = true;
const SERVER_URL = process.env.REACT_APP_SERVER_URL;

//development URL:
axios.defaults.baseURL = SERVER_URL;
// axios.defaults.baseURL = 'http://localhost:5000';

export async function onRegistration(registrationData) {
  return await axios.post('/api/register', registrationData);
}

export async function onLogin(loginData) {
  return await axios.post('/api/login', loginData);
}

export async function onLogout() {
  return await axios.get('/api/logout');
}

export async function authorizeUser() {
  return await axios.get('/api/get-user');
}

export async function initialAuth() {
  return await axios.get('/api/initial-auth');
}
