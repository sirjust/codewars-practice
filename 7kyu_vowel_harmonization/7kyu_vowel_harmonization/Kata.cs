using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_vowel_harmonization
{
    public static class Kata
    {
        public static string Dative(string word)
        {
            string returnString;
            char[] frontVowels = { 'e', 'é', 'i', 'í', 'ö', 'ő', 'ü', 'ű' } ;
            char[] backVowels = { 'a', 'á', 'o', 'ó', 'u', 'ú' };
            char[] wordArray = word.ToCharArray();
            for(int i= wordArray.Length - 1; i >= 0; i--)
            {
                if (backVowels.Contains(wordArray[i]))
                {
                    return returnString = word + "nak";
                }
                else if (frontVowels.Contains(wordArray[i]))
                {
                    return returnString = word + "nek";
                }
                else continue;
            }
            return null;
        }
    }
}
