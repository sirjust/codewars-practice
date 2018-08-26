using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_InspiringStringsWithTests
{
    public class Class1
    {
        public static string LongestWord(string stringOfWords)
        {
            string[] arrayOfWords = stringOfWords.Split(' ');
            string longestWord = arrayOfWords[0];
            for(int i = 1; i < arrayOfWords.Length; i++)
            {
                if (arrayOfWords[i].Length >= longestWord.Length)
                {
                    longestWord = arrayOfWords[i];
                }
            }
            return longestWord;
        }
    }
}
