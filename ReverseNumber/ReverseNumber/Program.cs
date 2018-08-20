using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    // of note: since the output is integer, if the number ends in a zero it will cut it off
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseNumber(-230001));
            Console.ReadLine();
        }

        static public int ReverseNumber(int n)
        {
            bool negative = false;
            if (n < 0)
            {
                n *= -1;
                negative = true;
            }
            var splitUp = n.ToString().ToCharArray();
            int totalChars = splitUp.Length;
            char[] reversed = new char[totalChars];
            foreach(char c in splitUp)
            {
                reversed[totalChars-1] = c;
                totalChars--;
            }
            string almostThere = string.Join("", reversed);
            int absoluteValue = int.Parse(almostThere);
            int complete = absoluteValue;
            if (negative)
            {
                complete *= -1;
            }
            return complete;
        }
    }
}
