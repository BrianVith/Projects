import { DomainRating, Volatility, GVS } from '../interfaces/index.js';

export const CalculateGVS = (volatilityList: Volatility[] | null, domainRatingList: DomainRating[] | null) => {
  const gvsList = [];

  if (volatilityList == null || domainRatingList == null) {
    return null;
  }

  // sort volatilityList and domainRatingList from A-Z
  SortByKeyword(volatilityList);
  SortByKeyword(domainRatingList);

  // get mean of volatility and domainRating
  for (let i = 0; i < volatilityList.length; i++) {
    const volatilityMean = GetMean(volatilityList[i].volatility);
    const domainRatingMean = GetMean(domainRatingList[i].domainRating);

    const volatilityPercentage = volatilityMean / 100;

    const gvs: GVS = {
      id: i,
      keyword: volatilityList[i].keyword,
      googleVolatilityScore: Math.round(volatilityPercentage * domainRatingMean),
      device: volatilityList[i].device,
    };

    gvsList.push(gvs);
  }

  return gvsList;
};

type listValues = Volatility[] | DomainRating[];
const SortByKeyword = (list: listValues) => {
  //sorts alphabetically ascending based on the keyword property in the list
  return list.sort((a, b) => a.keyword.localeCompare(b.keyword));
};

const GetMean = (list: number[]) => {
  let sum = 0;
  for (let i = 0; i < list.length; i++) {
    sum += list[i];
  }
  return sum / list.length;
};
