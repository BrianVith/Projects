import fetch from 'node-fetch';
import { TIME_PERIOD, API_KEY } from './constants/serpAPI.js';
import { Keyword, Volatility } from './interfaces/index.js';

export const GetVolatility = async (filteredKeywordList: Keyword[] | null | undefined) => {
  const volatilityList: Volatility[] = [];

  if (filteredKeywordList == null || filteredKeywordList == undefined) {
    return null;
  }

  for (const item of filteredKeywordList) {
    const url =
      'https://api.serpwoo.com/v1/volatility/' +
      item.projectID +
      '/' +
      item.keywordID +
      '/?since=' +
      TIME_PERIOD +
      '&key=' +
      API_KEY;
    try {
      const response = await fetch(url, {
        method: 'GET',
      });
      const result: any = await response.json();
      const volatilityData: number[] = [];
      for (let unixTimestamp in result[item.projectID][item.keywordID]) {
        const { volatility } = result[item.projectID][item.keywordID][unixTimestamp];
        volatilityData.push(volatility);
      }
      volatilityList.push({ keyword: item.keyword, volatility: volatilityData, device: item.device });
    } catch (error: any) {
      console.log('GetVolatility error: ', error.message);
    }
  }
  return volatilityList;
};

export default GetVolatility;
