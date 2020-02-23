using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile67Kata
{
    public class Kata
    {
        public string reverseAndCombineText(string text)
        {
            if (!text.Contains(' ')) return text;
            text = text.Replace("  ", " ");
            List<string> separatedWords = text.Split(' ').ToList<string>();

            int timesToCombine = (separatedWords.Count + 1) / 2;
            List<string> temp = new List<string>();
            for(int i = 0; i < timesToCombine; i++)
            {
                if (separatedWords.Count == 1) return separatedWords[0];
                for(int k = 0; k < separatedWords.Count; k++)
                {
                    separatedWords[k] = Reverse(separatedWords[k]);
                }

                for(int j = 0; j < separatedWords.Count; j += 2)
                {
                    if (j == separatedWords.Count - 1) 
                    {
                        temp.Add(separatedWords[j]);
                        continue;
                    }
                    string combinedWord = separatedWords[j] + separatedWords[j + 1];
                    temp.Add(combinedWord);
                }
                separatedWords = temp;
                temp = new List<string>();
            }
            return separatedWords[0];
        }
        private string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
