const url = 'http://localhost:5000/api/get-gvs';

export const GetGVS = async (keywordList: string[]) => {
  try {
    const response = await fetch(url, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ keywordList: keywordList }),
    });
    const result = await response.json();
    return result;
  } catch (error) {
    console.log(error);
  }
};
