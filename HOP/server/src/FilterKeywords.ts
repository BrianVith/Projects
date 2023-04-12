import { Keyword } from './interfaces/index.js';

const FilterKeywords = (keywordList: string[], allKeywords: Keyword[] | null | undefined) => {
  const filteredKeywordList: Keyword[] = [];

  if (allKeywords == null || allKeywords == undefined) {
    return null;
  }

  for (const keywordItem of allKeywords) {
    for (const searchedKeyword of keywordList) {
      if (keywordItem.keyword == searchedKeyword) {
        filteredKeywordList.push(keywordItem);
      }
    }
  }
  return filteredKeywordList;
};
export default FilterKeywords;
