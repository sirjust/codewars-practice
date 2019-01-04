using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_MyLanguages
{
    class Program
    {
        //Given a dictionary/hash/object of languages and your respective test results, return the list of languages where your test score is at least 60, in descending order of the results.
        //Note: There will be no duplicate values.
        static void Main(string[] args)
        {
            var test = new Dictionary<string, int> { { "Hindi", 60 }, { "Greek", 71 }, { "Dutch", 93 } };
            Kata.MyLanguages(test);

            Console.Read();
        }
    }
}
