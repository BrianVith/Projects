export interface Keyword extends KeywordData {
  projectID: string;
  keywordID: string;
}

export interface Volatility extends KeywordData {
  volatility: number[];
}

export interface DomainRating extends KeywordData {
  domainRating: number[];
}

export interface GVS extends KeywordData {
  id: number;
  googleVolatilityScore: number;
}

interface KeywordData {
  keyword: string;
  device: string;
}
