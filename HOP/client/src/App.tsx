import React, { useState } from 'react';
import './App.css';
import SaveKeywords from './components/SaveKeywords';
import ShowGVS from './components/ShowGVS';

function App() {
  const [keywordInput, setKeywordInput] = useState('');

  return (
    <div className="App">
      <ShowGVS keywordInput={keywordInput} setKeywordInput={setKeywordInput} />
      <SaveKeywords keywordInput={keywordInput} />
    </div>
  );
}

export default App;
