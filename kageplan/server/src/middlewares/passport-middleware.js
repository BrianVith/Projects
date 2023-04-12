const passport = require("passport");
const { Strategy } = require("passport-jwt");
const { SECRET, USER_TABLE_NAME } = require("../constants");
const db = require("../db");

const cookieExtractor = function (req) {
  let token = null;
  if (req && req.cookies) token = req.cookies["token"];
  return token;
};

const opts = {
  secretOrKey: SECRET,
  jwtFromRequest: cookieExtractor,
};

passport.use(
  new Strategy(opts, async ({ id }, done) => {
    try {
      const { rows } = await db.query(`SELECT user_id, user_email FROM ${USER_TABLE_NAME} WHERE user_id = $1`, [id]);

      if (rows.length === 0) {
        throw new Error("401 not authorized");
      }

      let user = { id: rows[0].user_id, email: rows[0].user_email };

      return await done(null, user);
    } catch (error) {
      console.log(error.message);

      done(null, false);
    }
  })
);
