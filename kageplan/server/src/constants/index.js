const { config } = require('dotenv');
config();

module.exports = {
  PORT: process.env.PORT,
  CLIENT_URL: process.env.CLIENT_URL,
  SECRET: process.env.SECRET,
  USER_TABLE_NAME: process.env.USER_TABLE_NAME,
  CAKE_TABLE_NAME: process.env.CAKE_TABLE_NAME,
  REGISTER_CODE: process.env.REGISTER_CODE,
  DB_USER: process.env.DB_USER,
  DB_PASSWORD: process.env.DB_PASSWORD,
  DB_HOST: process.env.DB_HOST,
  DB_DATABASE: process.env.DB_DATABASE,
  DB_PORT: process.env.DB_PORT,
};
