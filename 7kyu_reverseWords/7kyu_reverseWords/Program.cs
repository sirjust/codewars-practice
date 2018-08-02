using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_reverseWords
{
    //    Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
    //Examples

    //"This is an example!" ==> "sihT si na !elpmaxe"
    //"double  spaces"      ==> "elbuod  secaps"

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("Hello world!"));
            Console.ReadLine();
        }

        public static string ReverseWords(string str)
        {
            string[] myStrings = str.Split(' ');
            List<string> backwards = new List<string>();

            foreach (string word in myStrings)
            {
                char[] origChars = word.ToCharArray();
                List<char> backChars = new List<char>();
                for (int i = word.Length - 1; i > -1; i--)
                {
                    backChars.Add(origChars[i]);
                }
                string newString = string.Join("", backChars);
                backwards.Add(newString);
            }

            string result = string.Join(" ", backwards);
            return result;
        }
    }
}
