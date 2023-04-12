const express = require('express');
const app = express();
const { PORT, CLIENT_URL } = require('./constants');
const cookieParser = require('cookie-parser');
const passport = require('passport');
const cors = require('cors');

// import passport middleware
require('./middlewares/passport-middleware');

// initialize middlewares
app.use(express.json()); // => req.body
app.use(cookieParser());
app.use(cors({ origin: CLIENT_URL, credentials: true }));
app.use(passport.initialize());

//import routes
const authRoutes = require('./routes/auth');
const cakeRoutes = require('./routes/cakes');

//initialize routes
app.use('/api', authRoutes);
app.use('/api', cakeRoutes);

//app start
const appStart = () => {
  try {
    app.listen(PORT, () => {
      console.log(`Listening on port ${PORT}`);
    });
  } catch (error) {
    console.log(error.message);
  }
};

appStart();
