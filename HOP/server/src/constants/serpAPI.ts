export const API_KEY = 'D1452DC1-49D9-399B-811A-ADA6EEB6D7A0';
const UNIX_MONTH = 30.44; // a month in unix/epoch conversion rate --- ref: https://www.epochconverter.com/
export const TIME_PERIOD = Math.round(Date.now() / 1000 - 60 * 60 * 24 * UNIX_MONTH); // one month in seconds
