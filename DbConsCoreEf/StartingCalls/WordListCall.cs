using DbConsCoreEf.Enginner;
using DbConsCoreEf.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbConsCoreEf.StartingCalls
{
    class WordListCall
    {
      public WordListService _WlS;
        
        public async Task GetWordsTxtFile(string pathFie)
        {
           
            WordListEnginner We = new WordListEnginner();
            var WList = We.GetAllWordsClean(pathFie);
            _WlS = new WordListService();
            await _WlS.InsertAsync(WList);
        }
        public void ClearWordlist()
        {
            _WlS = new WordListService();
            _WlS.Clear();
        }

    }
}
