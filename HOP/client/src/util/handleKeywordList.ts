export const handleKeywordList = (keywordInput: string) => {
  //Magic regex code --> trims for whitespaces on each side of the comma
  //This allows keywords with mutiple words to have a whitespace between them
  return keywordInput.replace(/^\s+|\s+$/g, '').split(/\s*,\s*/);
};
