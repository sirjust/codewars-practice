using System;
using System.Linq;
using System.Collections.Generic;

namespace AlphabetSymmetry
{
    public static class Kata
    {
//        Consider the word "abode". We can see that the letter a is in position 1 and b is in position 2. In the alphabet, a and b are also in positions 1 and 2. Notice also that d and e in abode occupy the positions they would occupy in the alphabet, which are positions 4 and 5.

//Given an array of words, return an array of the number of letters that occupy their positions in the alphabet for each word.For example,

//solve(["abode", "ABc", "xyzD"]) = [4, 3, 1]
//See test cases for more examples.

//Input will consist of alphabet characters, both uppercase and lowercase. No spaces.
        public static List<int> Solve(List<string> arr)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<int> result = new List<int>();
            foreach(string s in arr)
            {
                string lower = s.ToLower();
                int counter = 0;
                for(int i=0; i < s.Length; i++) {
                    if(lower[i] == alphabet[i])
                    {
                        counter++;
                    }
                }
                result.Add(counter);
            }
            return result;
        }
    }
}
