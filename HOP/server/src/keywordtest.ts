import fetch from 'node-fetch';

const API_KEY = 'D1452DC1-49D9-399B-811A-ADA6EEB6D7A0';
const PROJECT_ID = 87556; //input your Project ID
const Keyword_ID = 696881; //input your Keyword ID
const unixMonth = 30.44; // a month in unix/epoch conversion rate --- ref: https://www.epochconverter.com/
const timeperiod = Math.round(Date.now() / 1000 - 60 * 60 * 24 * unixMonth); // one month in seconds

const url = 'https://api.serpwoo.com/v1/projects/' + PROJECT_ID + '/keywords/?key=' + API_KEY;

const apiCall = async () => {
  try {
    let response = await fetch(url, {
      method: 'GET',
    });
    const result: any = await response.json();

    //console.log(result[PROJECT_ID][Keyword_ID]);

    for (var id in result['projects'][PROJECT_ID]['keywords']) {
      console.log('id: ', id, 'keyword: ', result['projects'][PROJECT_ID]['keywords'][id]['keyword']);
      //console.log('id: ', id);
    }

    return result;
  } catch (error) {
    console.log(error);
  }
};

apiCall();
