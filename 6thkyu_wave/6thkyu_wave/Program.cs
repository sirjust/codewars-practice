using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In this simple Kata your task is to create a function that turns a string into a wave.
//You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up.
//Rules
//  	1.  The input string will always be lower case but maybe empty.

//      2.  If the character in the string is whitespace then pass over it as if it was an empty seat.

//Example   wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]

namespace _6thkyu_wave
{
    class Program
    {
        static void Main(string[] args)
        {
            var asList = wave("hello");
            asList = wave("wave me");
            asList = wave(" gap ");
            string printable = string.Join(", ", asList);
            Console.WriteLine(printable);
            Console.ReadLine();
        }

        public static List<string> wave(string str)
        {
            List<string> myList = new List<string>();
            char[] myArray = str.ToCharArray();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == ' ')
                {
                    continue;
                }
                char[] workableArray = myArray;
                char waveMe = char.ToUpper(workableArray[i]);
                workableArray[i] = waveMe;
                string oneUpString = string.Join("", workableArray);
                char sitDown = char.ToLower(myArray[i]);
                myArray[i] = sitDown;
                myList.Add(oneUpString);
            }
            return myList;
        }
    }
}
