const jwt = require('jsonwebtoken');
const { SECRET } = require('../constants');

module.exports = async (req, res, next) => {
  try {
    const jwtToken = req.cookies.token;
    if (!jwtToken) {
      return res.status(403).json('Unauthorized');
    }

    const payload = jwt.verify(jwtToken, SECRET);

    req.user = payload.user;
    next();
  } catch (err) {
    console.error(err.message);
    return res.status(403).json('Unauthorized');
  }
};
