using System;
using System.Collections.Generic;
using System.Text;

namespace _7thkyu_beach
{
    class Kata
    {
        public static int SumOfABeach(string s)
        {
            string wordOne = "sand";
            string wordTwo = "water";
            string wordThree = "fish";
            string wordFour = "sun";
            string newString = s.ToLower();
            int Count = 0;
            int i = 0;
            while ((i = newString.IndexOf(wordOne, i)) != -1)
                {
                i += wordOne.Length;
                Count++;
                }
            i = 0;
            while ((i = newString.IndexOf(wordTwo, i)) != -1)
            {
                i += wordTwo.Length;
                Count++;
            }
            i = 0;
            while ((i = newString.IndexOf(wordThree, i)) != -1)
            {
                i += wordThree.Length;
                Count++;
            }
            i = 0;
            while ((i = newString.IndexOf(wordFour, i)) != -1)
            {
                i += wordFour.Length;
                Count++;
            }
            return Count;
        }
    }
}
