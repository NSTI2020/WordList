using DbConsCoreEf.Enginner;
using DbConsCoreEf.Service;
using System.Linq;
using System;
using System.Threading.Tasks;
using DbConsCoreEf.StartingCalls;

namespace DbConsCoreEf
{
    class Program
    {
       
        static  async Task Main(string[] args)
        {
            WordListCall wCall = new WordListCall();
            LetterCall lS = new LetterCall();
            await wCall.GetWordsTxtFile(@"c:\users\marcus\desktop\az.txt");
            await lS.OrderAll();
        }
    }
}
