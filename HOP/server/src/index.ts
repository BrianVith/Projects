import express from 'express';
import cors from 'cors';
import GetVolatility from './GetVolatility.js';
import GetAllKeywords from './GetAllKeywords.js';
import FilterKeywords from './FilterKeywords.js';
import GetDomainRating from './GetDomainRating.js';
import { CalculateGVS } from './util/CalculateGVS.js';
const app = express();

// --- Middleware ---
app.use(cors());
app.use(express.json()); // allows to access req.body

// --- Routes ---

// get GVS value for multiple keywords
app.post('/api/get-gvs', async (req, res) => {
  try {
    const { keywordList } = req.body; //input your Keyword ID

    const allKeywords = await GetAllKeywords();
    const filteredKeyWords = FilterKeywords(keywordList, allKeywords);
    const volatilityList = await GetVolatility(filteredKeyWords);
    const domainRatingList = GetDomainRating(filteredKeyWords);
    const gvsList = CalculateGVS(volatilityList, domainRatingList);

    res.json(gvsList);
  } catch (error) {
    console.log('get-gvs error: ', error);
  }
});

app.listen(5000, () => {
  console.log('Server is running on port 5000');
});
