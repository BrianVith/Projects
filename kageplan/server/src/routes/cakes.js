const express = require('express');
const { getCakes, getCakeFromId, addCake, deleteCake, editCake } = require('../controllers/cakeController');
const jwtCheck = require('../middlewares/jwt-middleware');
const router = express.Router();

//cake specific routes
router.get('/cakes', jwtCheck, getCakes);
router.get('/cakes/:id', jwtCheck, getCakeFromId);
router.post('/cakes', jwtCheck, addCake);
router.patch('/cakes/:id', jwtCheck, editCake);
router.delete('/cakes/:id', jwtCheck, deleteCake);

module.exports = router;
