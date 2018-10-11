using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu_wordspin
{
    class Kata
    {
        public static string SpinWords(string sentence)
        {
            string reversedSentence;
            string[] sentenceArray = sentence.Split(' ');
            for(int i = 0; i<sentenceArray.Length; i++)
            {
                char[] wordCharArray = sentenceArray[i].ToCharArray();
                int count = wordCharArray.Count();
                if (count >= 5)
                {
                    string reversedString = ReverseCharArray(wordCharArray);
                    sentenceArray[i] = reversedString;
                }
            }
            reversedSentence = string.Join(" ", sentenceArray);
            return reversedSentence;
        }

        public static string ReverseCharArray(char[] word)
        {
            string reversedString;
            char[] reversedArray = new char[word.Length];
            int backcount = word.Length - 1;
            for(int i = 0; i< word.Length; i++)
            {
                reversedArray[backcount] = word[i];
                backcount--;
            }
            reversedString = string.Join("", reversedArray);
            return reversedString;
        }
    }
}
