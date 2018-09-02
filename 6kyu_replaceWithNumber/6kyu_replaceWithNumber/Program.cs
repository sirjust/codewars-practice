using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// In this kata you are required to, given a string, replace every letter with its position in the alphabet.
// If anything in the text isn't a letter, ignore it and don't return it.
// a being 1, b being 2, etc.

// note: this is my first time using a dictionary.. i hope to find a better way to populate it

namespace _6kyu_replaceWithNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
            Console.Read();
        }

        public static string AlphabetPosition(string text)
        {
            char[] myCharArray = text.ToCharArray();

            Dictionary<char, int> alphabetValues = new Dictionary<char, int>();
            alphabetValues.Add('a', 1);
            alphabetValues.Add('b', 2);
            alphabetValues.Add('c', 3);
            alphabetValues.Add('d', 4);
            alphabetValues.Add('e', 5);
            alphabetValues.Add('f', 6);
            alphabetValues.Add('g', 7);
            alphabetValues.Add('h', 8);
            alphabetValues.Add('i', 9);
            alphabetValues.Add('j', 10);
            alphabetValues.Add('k', 11);
            alphabetValues.Add('l', 12);
            alphabetValues.Add('m', 13);
            alphabetValues.Add('n', 14);
            alphabetValues.Add('o', 15);
            alphabetValues.Add('p', 16);
            alphabetValues.Add('q', 17);
            alphabetValues.Add('r', 18);
            alphabetValues.Add('s', 19);
            alphabetValues.Add('t', 20);
            alphabetValues.Add('u', 21);
            alphabetValues.Add('v', 22);
            alphabetValues.Add('w', 23);
            alphabetValues.Add('x', 24);
            alphabetValues.Add('y', 25);
            alphabetValues.Add('z', 26);
            alphabetValues.Add('A', 1);
            alphabetValues.Add('B', 2);
            alphabetValues.Add('C', 3);
            alphabetValues.Add('D', 4);
            alphabetValues.Add('E', 5);
            alphabetValues.Add('F', 6);
            alphabetValues.Add('G', 7);
            alphabetValues.Add('H', 8);
            alphabetValues.Add('I', 9);
            alphabetValues.Add('J', 10);
            alphabetValues.Add('K', 11);
            alphabetValues.Add('L', 12);
            alphabetValues.Add('M', 13);
            alphabetValues.Add('N', 14);
            alphabetValues.Add('O', 15);
            alphabetValues.Add('P', 16);
            alphabetValues.Add('Q', 17);
            alphabetValues.Add('R', 18);
            alphabetValues.Add('S', 19);
            alphabetValues.Add('T', 20);
            alphabetValues.Add('U', 21);
            alphabetValues.Add('V', 22);
            alphabetValues.Add('W', 23);
            alphabetValues.Add('X', 24);
            alphabetValues.Add('Y', 25);
            alphabetValues.Add('Z', 26);

            string newText = "";
            foreach (char c in myCharArray)
            {
                try
                {
                    alphabetValues.TryGetValue(c, out int value);
                    if (value == 0)
                    {
                        continue;
                    }
                    newText = newText + value.ToString() + " ";
                }
                catch
                {
                    continue;
                }

            }
            newText = newText.TrimEnd(' ');
            return newText;
        }
    }
}
