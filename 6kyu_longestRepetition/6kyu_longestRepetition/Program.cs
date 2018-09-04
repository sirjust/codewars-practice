using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For a given string find the character c with longest consecutive repetition and return a tuple
// For empty string return in C# Tuple<char, int>(null, 0)

// note: i would like to do this without needing two for loops.. i will revisit in a few months

namespace _6kyu_longestRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = LongestRepetition("aaabbaaaa");
            var second = LongestRepetition("abbbbb");
            Console.WriteLine("{0} {1}      {2} {3}", first.Item1, first.Item2, second.Item1, second.Item2);
            Console.Read();
        }

        public static Tuple<char?, int> LongestRepetition(string input)
        {
            Tuple<char?, int> answer = new Tuple<char?, int>(null, 0);
            if (input == "")
            {
                return answer;
            }
            char[] inputArray = input.ToCharArray();
            char answerChar = inputArray[0];
            int answerInt = 1;
            for(int i = 0; i < inputArray.Length; i++)
            {
                char character = inputArray[i];
                int occurences=0;
                for(int j = i; j < inputArray.Length; j++)
                {
                    if(inputArray[j] != character)
                    {
                        break;
                    }
                    if(inputArray[j] == character)
                    {
                        occurences += 1;
                    }
                }
                if (occurences > answerInt)
                {
                    answerChar = inputArray[i];
                    answerInt = occurences;
                }
            }
            answer = new Tuple<char?, int>(answerChar, answerInt);
            return answer;
        }
    }
}
