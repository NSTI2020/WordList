using DbConsCoreEf.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbConsCoreEf.StartingCalls
{
    class LetterCall
    {
        public async Task OrderAll()
        {
            
            WordListService wLs = new WordListService();
            LetterService Le = new LetterService();
            await Le.OrderByLetter("a");
            await Le.OrderByLetter("b");
            await Le.OrderByLetter("c");
            await Le.OrderByLetter("d");
            await Le.OrderByLetter("e");
            await Le.OrderByLetter("f");
            await Le.OrderByLetter("g");
            await Le.OrderByLetter("h");
            await Le.OrderByLetter("i");
            await Le.OrderByLetter("j");
            await Le.OrderByLetter("k");
            await Le.OrderByLetter("l");
            await Le.OrderByLetter("m");
            await Le.OrderByLetter("n");
            await Le.OrderByLetter("o");
            await Le.OrderByLetter("p");
            await Le.OrderByLetter("q");
            await Le.OrderByLetter("r");
            await Le.OrderByLetter("s");
            await Le.OrderByLetter("t");
            await Le.OrderByLetter("u");
            await Le.OrderByLetter("v");
            await Le.OrderByLetter("w");
            await Le.OrderByLetter("x");
            await Le.OrderByLetter("y");
            await Le.OrderByLetter("z");
            wLs.Clear();




        }
    }
}
