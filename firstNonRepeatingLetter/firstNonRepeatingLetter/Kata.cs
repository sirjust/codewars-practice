using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a function named firstNonRepeatingLetter† that takes a string input, and returns the first character that is not 
//    repeated anywhere in the string.

//For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, 
//    and occurs first in the string.

//As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the 
//    correct case for the initial letter.For example, the input 'sTreSS' should return 'T'.

//If a string contains all repeating characters, it should return the empty string ("").

//† Note: the function is called firstNonRepeatingLetter for historical reasons, but your function should handle any Unicode character.

namespace firstNonRepeatingLetter
{
    class Kata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            StringBuilder builder = new StringBuilder();
            char[] keepCase = s.ToCharArray();
            char[] lettersToCheck = s.ToLower().ToCharArray();
            for(int i = 0; i < lettersToCheck.Length; i++)
            {
                bool thisRepeats = false;
                for(int j = 0; j < lettersToCheck.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (lettersToCheck[i] == lettersToCheck[j])
                    {
                        thisRepeats = true;
                        break;
                    }
                }
                if (thisRepeats)
                {
                    continue;
                }
                builder.Append(keepCase[i].ToString());
                break;
            }
            string result = builder.ToString();
            return result;
        }
    }
}
