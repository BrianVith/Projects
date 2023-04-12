import fetch from 'node-fetch';
import { API_KEY } from './constants/serpAPI.js';
import { Keyword } from './interfaces/index.js';

const url = 'https://api.serpwoo.com/v1/keywords/?key=' + API_KEY;

const GetAllKeywords = async () => {
  try {
    let response = await fetch(url, { method: 'GET' });
    const jsonData = await response.json();

    const allKeywords: Keyword[] = [];

    for (const projectID in jsonData.projects) {
      for (const keywordID in jsonData.projects[projectID].keywords) {
        const keyword: Keyword = {
          projectID: projectID,
          keywordID: keywordID,
          keyword: jsonData.projects[projectID].keywords[keywordID].keyword,
          device: jsonData.projects[projectID].keywords[keywordID].settings.device,
        };
        allKeywords.push(keyword);
      }
    }

    if (allKeywords == null || allKeywords == undefined) {
      return null;
    }

    return allKeywords;
  } catch (error) {
    console.log('GetAllKeywords error: ', error);
  }
};
export default GetAllKeywords;
