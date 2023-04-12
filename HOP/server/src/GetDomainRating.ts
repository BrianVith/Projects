import { DomainRating, Keyword } from './interfaces/index';

const getRandomInt = (min: number, max: number) => {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min) + min);
};

const GetDomainRating = (filteredKeywordList: Keyword[] | null | undefined) => {
  const domainRatingList: DomainRating[] = [];

  if (filteredKeywordList == null || filteredKeywordList == undefined) {
    return null;
  }
  for (const item of filteredKeywordList) {
    const randomDomainRatingDataList: number[] = [];
    for (let i = 0; i < 10; i++) {
      randomDomainRatingDataList.push(getRandomInt(40, 75));
    }
    const DR: DomainRating = { keyword: item.keyword, domainRating: randomDomainRatingDataList, device: item.device };

    domainRatingList.push(DR);
  }
  return domainRatingList;
};

export default GetDomainRating;
