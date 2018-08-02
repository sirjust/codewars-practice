using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In this Kata, you will be given a string that may have mixed uppercase and lowercase letters and your task is to convert that string to either lowercase only or uppercase only based on:

//    make as few changes as possible.
//    if the string contains equal number of uppercase and lowercase letters, convert the string to lowercase.

namespace _7kyu_fixCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("code"));
            Console.WriteLine(Solve("CODe"));
            Console.WriteLine(Solve("COde"));
            Console.WriteLine(Solve("Code"));
            Console.ReadLine();
        }

        public static string Solve(string s)
        {
            var myArray = s.ToCharArray();
            int upperCounter = 0;
            int lowerCounter = 0;
            string result;

            foreach (char c in myArray)
            {
                if (char.IsUpper(c))
                {
                    upperCounter++;
                }
                else
                {
                    lowerCounter++;
                }
            }
            if (lowerCounter >= upperCounter)
            {
                result = s.ToLower();
            }
            else
            {
                result = s.ToUpper();
            }
            return result;
        }
    }
}
