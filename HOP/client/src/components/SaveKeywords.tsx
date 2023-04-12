import { Fragment, useEffect, useState } from 'react';
import { KeywordGroup } from '../Interfaces';
import { handleKeywordList } from '../util/handleKeywordList';

interface props {
  keywordInput: string;
}

const SaveKeywords = ({ keywordInput }: props) => {
  const [groupNameInput, setGroupNameInput] = useState('');
  const [keywordGroup, setKeywordGroup] = useState<KeywordGroup[]>([]);
  const [initialRender, setInitailRender] = useState(true);

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setGroupNameInput(e.target.value);
  };

  const SaveKeywordGroup = (e: React.MouseEvent<HTMLButtonElement, MouseEvent>) => {
    const inputGroup: KeywordGroup = {
      groupName: groupNameInput,
      keywords: handleKeywordList(keywordInput),
    };

    let tempGroup: KeywordGroup[] = [];
    const temp = localStorage.getItem('keywordGroup');
    if (temp != null) {
      tempGroup = JSON.parse(temp);
    }
    tempGroup.push(inputGroup);
    setKeywordGroup(tempGroup);
  };

  useEffect(() => {
    if (initialRender) {
      setInitailRender(false);
      return;
    }
    localStorage.setItem('keywordGroup', JSON.stringify(keywordGroup));
  }, [keywordGroup]);

  return (
    <Fragment>
      <div>
        <label htmlFor="keywordGroup">Input Name for group of keywords</label>
        <input
          name="keywordGroup"
          type="text"
          placeholder="Name"
          value={groupNameInput}
          onChange={(e) => handleChange(e)}
        />
      </div>
      <button onClick={(e) => SaveKeywordGroup(e)}>Save Keywords</button>
      <div>{/* Insert keyword grouping component */}</div>
    </Fragment>
  );
};

export default SaveKeywords;
