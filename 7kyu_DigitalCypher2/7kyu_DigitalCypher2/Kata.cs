using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_DigitalCypher2
{
    public class Kata
    {
        public static string Decode(int[] code, int key)
        {
            // this list will contain the deciphered characters
            List<string> decodedLetters = new List<string>();

            // make dictionary assigning values to letters
            char[] c = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int dictionaryKey = 1;
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            foreach (char value in c)
            {
                myDictionary.Add(dictionaryKey, value.ToString());
                dictionaryKey++;
            }

            // convert the key to an array of integers for easy adding
            int[] keyArray = key.ToString().Select(o => Convert.ToInt32(o) -48).ToArray();
            int j = 0;
            // iterate through the decoded numbers and subtract the values
            for(int i = 0; i<code.Length; i++)
            {
                while(j < code.Length)
                {
                    // we need to loop back to the beginning of the key until code is exhausted
                    code[i] = code[i] - keyArray[j];
                    j++;
                    if (j == keyArray.Length)
                    {
                        j = 0;
                    }
                    break;
                }
            }

            for(int k = 0; k < code.Length; k++)
            {
                string letterToAdd = myDictionary[code[k]];
                decodedLetters.Add(letterToAdd);
            }
            string answer = String.Join("", decodedLetters);

            return answer;
        }
    }
}
