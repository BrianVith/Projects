const { check } = require('express-validator');
const db = require('../db');
const { compare } = require('bcryptjs');
const { USER_TABLE_NAME, REGISTER_CODE } = require('../constants');

//username
//password
const username = check('name').isLength({ min: 2 }).withMessage('Username has to be minimum 2 characters.');

//password
const password = check('password')
  .isLength({ min: 6, max: 15 })
  .withMessage('Password has to be between 6 and 15 characters.');

//validate password
const validateConfirmPassword = check('confirmPassword').custom(async (confirmPassword, { req }) => {
  const pw = req.body.password;

  if (pw !== confirmPassword) throw new Error('Password does not match Confirm Password');
});

const validateRegisterCode = check('registerCode').custom(async (registerCode) => {
  if (registerCode !== REGISTER_CODE) throw new Error('Register code is invalid');
});

//email
const email = check('email').isEmail().withMessage('Please provide a valid email.');

//check if email exists
const emailExists = check('email').custom(async (value) => {
  const { rows } = await db.query(`SELECT * from ${USER_TABLE_NAME} WHERE user_email = $1`, [value]);

  if (rows.length) {
    throw new Error('Email already exists.');
  }
});

//login validation
const loginFieldsCheck = check('email').custom(async (value, { req }) => {
  const user = await db.query(`SELECT * from ${USER_TABLE_NAME} WHERE user_email = $1`, [value]);
  if (!user.rows.length) {
    throw new Error('Wrong email or password');
  }

  const validPassword = await compare(req.body.password, user.rows[0].user_password);

  if (!validPassword) {
    throw new Error('Wrong email or password');
  }

  req.user = user.rows[0];
});

module.exports = {
  registerValidation: [username, email, password, emailExists, validateConfirmPassword, validateRegisterCode],
  loginValidation: [loginFieldsCheck],
};
