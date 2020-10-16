using DbConsCoreEf.Data;
using DbConsCoreEf.Entities;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbConsCoreEf.Enginner;


namespace DbConsCoreEf.Service
{
    class WordListService
    {
        private readonly ConsEfDbContext _context;
        private List<string> _wordList { get; set; }
        private WordList _wL { get; set; }
        private MsgEnginner _msg { get; set; }
        public WordListService()
        {
            _wordList = new List<string>();
            _msg = new MsgEnginner();
            _context = new ConsEfDbContext();
        }
        public async Task InsertAsync(List<string> Words)
        {
            _wordList = Words;
            foreach (string word in _wordList)
            {
                _wL = new WordList() { Word = word };
                await _context.wordLists.AddAsync(_wL);
                System.Console.WriteLine(_msg.Adding() + " {0}", word);
                _context.SaveChanges();
            }
        }
        public async Task<ICollection<WordList>> FindAllAsync()
        {
            _wL = new WordList();
            return await _context.wordLists.ToListAsync();
        }
        public void Clear()
        {
            _wL = new WordList();
            var wList = _context.wordLists.ToList();
            foreach (WordList Wl in wList)
            {
                _msg = new MsgEnginner();
                _context.wordLists.RemoveRange(Wl);
                Console.WriteLine(_msg.ClearWordLis());
                _context.SaveChanges();
            }
        }
    }
}
