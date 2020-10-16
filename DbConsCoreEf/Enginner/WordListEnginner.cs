using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace DbConsCoreEf.Enginner
{
    class WordListEnginner
    {
        private List<string> WordList { get; set; }
        private List<string> WordListReturn { get; set; }
        private List<string> CleanListReturn { get; set; }
        private StreamReader sReader { get; set; }
        private string[] txtReturn { get; set; }
        public WordListEnginner()
        {
            WordList = new List<string>();
            WordListReturn = new List<string>();
            CleanListReturn = new List<string>();
        }
        public List<string> StartingWith(string file, string letter)
        {
            sReader = new StreamReader(file);
            txtReturn = sReader.ReadToEnd().Split(',', ' ');
            foreach (string toAddList in txtReturn)
            {
                WordList.Add(toAddList);
            }
            foreach (string filteredData in WordList)
            {
                if (filteredData.ToUpper().StartsWith(letter.ToUpper()))
                    WordListReturn.Add(filteredData);
            }
            sReader.Close();
            return WordListReturn;

        }
        public List<string> GetAllWordsClean(string file)
        {
            while (string.IsNullOrEmpty(file))
            {
              Console.WriteLine("Por favor, insira o caminho do txt com as palavras separadas por virgula (,). Obrigado!");
              file =  Console.ReadLine();
            }
            sReader = new StreamReader(file);
            txtReturn = sReader.ReadToEnd().Split(',', ' ');
            foreach (string toAddList in CleaningList(txtReturn.ToList()))
            {
                WordList.Add(toAddList);
            }
            foreach (string filteredData in WordList)
            {
                WordListReturn.Add(filteredData);
            }
            sReader.Close();
            return WordListReturn;
        }
        public List<string> CleaningList(List<string> cleaning)
        {
            var removingDuplicate = cleaning.Distinct();

            foreach (string word in removingDuplicate)
            {
                if (!string.IsNullOrEmpty(word)|| !string.IsNullOrWhiteSpace(word))
                {
                    CleanListReturn.Add(word);
                }
            }
            return CleanListReturn;
        }
    }
}
