const express = require('express');
const { getUsers, getCurrentUser, register, login, initialAuth, logout } = require('../controllers/auth');
const { registerValidation, loginValidation } = require('../validators/auth');
const { validationMiddleware } = require('../middlewares/validations-middleware');
const { userAuth } = require('../middlewares/auth-middleware');
const router = express.Router();

// user specific routes
router.get('/initial-auth', userAuth, initialAuth);
router.get('/get-user', userAuth, getCurrentUser);
router.get('/get-users', getUsers);
router.post('/register', registerValidation, validationMiddleware, register);
router.post('/login', loginValidation, validationMiddleware, login);
router.get('/logout', logout);

module.exports = router;
