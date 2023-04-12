import React, { Dispatch, Fragment, SetStateAction, useState } from 'react';
import { GetGVS } from '../api/getGVS';
import { handleKeywordList } from '../util/handleKeywordList';

interface GVS {
  id: number;
  keyword: string;
  googleVolatilityScore: number;
  device: string;
}

const initialState: GVS[] = [
  {
    id: 0,
    keyword: '',
    googleVolatilityScore: 0,
    device: '',
  },
];

interface props {
  keywordInput: string;
  setKeywordInput: Dispatch<SetStateAction<string>>;
}

const ShowGVS = ({ keywordInput, setKeywordInput }: props) => {
  const [gvs, setGvs] = useState<GVS[]>(initialState);

  const gvsTable = gvs.map((item) => (
    <tr key={item.id}>
      <td>{item.keyword}</td>
      <td>{item.googleVolatilityScore}</td>
      <td>{item.device}</td>
    </tr>
  ));

  const FetchGVS = async (e: React.MouseEvent<HTMLButtonElement, MouseEvent>) => {
    const keywordList = handleKeywordList(keywordInput);
    const gvsResponse = await GetGVS(keywordList);
    if (gvsResponse != null) {
      setGvs(gvsResponse);
    } else {
      setGvs(initialState);
    }
    setKeywordInput('');
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setKeywordInput(e.target.value);
  };

  return (
    <Fragment>
      <div>
        <div>
          <label htmlFor="keyword">Input keywords </label>
          <input
            name="keyword"
            type="text"
            placeholder="Keyword"
            value={keywordInput}
            onChange={(e) => handleChange(e)}
          />
        </div>
        <button onClick={(e) => FetchGVS(e)}>Fetch GVS</button>
        <table>
          <thead>
            <tr>
              <th>Keyword</th>
              <th>GVS</th>
            </tr>
          </thead>
          <tbody>{gvsTable}</tbody>
        </table>
      </div>
    </Fragment>
  );
};

export default ShowGVS;
