const db = require('../db');
const { CAKE_TABLE_NAME, USER_TABLE_NAME } = require('../constants');

// Get all cakes
exports.getCakes = async (req, res) => {
  try {
    //const allCakes = await db.query(`select * from ${CAKE_TABLE_NAME}`);
    const allCakes = await db.query(
      `select ${USER_TABLE_NAME}.user_name, ${USER_TABLE_NAME}.user_id, cake_id, cake_type, cake_occasion, start_date,end_date from ${CAKE_TABLE_NAME} join ${USER_TABLE_NAME} on ${USER_TABLE_NAME}.user_id = ${CAKE_TABLE_NAME}.user_id`
    );

    res.json(allCakes.rows);
  } catch (error) {
    console.log(error.message);
  }
};

// Get cake from id
exports.getCakeFromId = async (req, res) => {
  const { id } = req.params;
  try {
    const cakeId = await db.query(`select * from ${CAKE_TABLE_NAME} where cake_id = $1`, [id]);

    res.json(cakeId.rows[0]);
  } catch (error) {
    console.log(error.message);
  }
};

// Create cake
exports.addCake = async (req, res) => {
  try {
    const { userId, cakeType, cakeOccasion, start, end } = req.body;
    const newCake = await db.query(
      `INSERT INTO ${CAKE_TABLE_NAME} (user_id,cake_type,cake_occasion,start_date,end_date) VALUES ($1,$2,$3,$4,$5) RETURNING *`,
      [userId, cakeType, cakeOccasion, start, end]
    );

    res.json(newCake.rows[0]);
  } catch (err) {
    console.log(err.message);
  }
};

// Delete cake
exports.deleteCake = async (req, res) => {
  try {
    const { id } = req.params;
    const deleteCake = await db.query(`delete from ${CAKE_TABLE_NAME} where cake_id = $1`, [id]);

    res.json('cake was deleted');
  } catch (error) {
    console.log(error.message);
  }
};

// Update cake
exports.editCake = async (req, res) => {
  try {
    const { id } = req.params;
    const { userId, cakeType, cakeOccasion, start, end } = req.body;
    const editCake = await db.query(
      `UPDATE ${CAKE_TABLE_NAME} SET (cake_type,cake_occasion,start_date,end_date) = ($1,$2,$3,$4) where cake_id = $5 AND user_id = $6 RETURNING *`,
      [cakeType, cakeOccasion, start, end, id, userId]
    );

    res.json(editCake.rows[0]);
  } catch (error) {
    console.log(err.message);
  }
};
