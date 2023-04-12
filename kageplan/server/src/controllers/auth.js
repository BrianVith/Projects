const db = require('../db');
const { hash } = require('bcryptjs');
const { sign } = require('jsonwebtoken');
const { SECRET, USER_TABLE_NAME } = require('../constants');

exports.getUsers = async (req, res) => {
  try {
    const { rows } = await db.query(`select user_id, user_email from ${USER_TABLE_NAME}`);

    return res.status(200).json({
      success: true,
      users: rows,
    });
  } catch (error) {
    console.log(error.message);
  }
};

exports.getCurrentUser = async (req, res) => {
  const { id } = req.user;
  try {
    const user = await db.query(`select user_name,user_id from ${USER_TABLE_NAME} where user_id = $1`, [id]);
    const username = user.rows[0].user_name;
    const user_id = user.rows[0].user_id;
    return res.status(200).json({ username: username, user_id: user_id });
  } catch (error) {
    console.log(error.message);
  }
};

exports.register = async (req, res) => {
  const { name, email, password } = req.body;
  try {
    const hashedPassword = await hash(password, 10);

    await db.query(`insert into ${USER_TABLE_NAME}(user_name,user_email,user_password) values ($1 , $2, $3)`, [
      name,
      email,
      hashedPassword,
    ]);

    return res.status(201).json({
      success: true,
      message: 'The registration was succesfull',
    });
  } catch (error) {
    console.log(error.message);
    return res.status(500).json({
      error: error.message,
    });
  }
};

exports.login = async (req, res) => {
  let user = req.user;

  let payload = {
    id: user.user_id,
    email: user.user_email,
  };

  try {
    const token = await sign(payload, SECRET);

    return res.status(200).cookie('token', token, { httpOnly: true, sameSite: 'none', secure: true }).json({
      success: true,
      message: 'Logged in succefully',
    });
  } catch (error) {
    console.log(error.message);
    return res.status(500).json({
      error: error.message,
    });
  }
};

exports.initialAuth = async (req, res) => {
  try {
    return res.status(200).json({
      login: true,
    });
  } catch (error) {
    console.log(error.message);
  }
};

exports.logout = async (req, res) => {
  try {
    return res.status(200).clearCookie('token', { httpOnly: true }).json({
      success: true,
      message: 'Logged out succefully',
    });
  } catch (error) {
    console.log(error.message);
    return res.status(500).json({
      error: error.message,
    });
  }
};
