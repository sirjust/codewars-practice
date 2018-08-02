using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// printer colors are from a to m, sometimes characters show up outside of these
// write a function that produces a fraction where the numerator is
// the number of errors and the denominator is the total number of characters
// examples: s="aaabbbbhaijjjm"
// error_printer(s) => "0/14"
// s = "aaaxbbbbyyhwawiwjjjwwm"
// error_printer(s) => "8/22"

namespace _7kyu_printerError
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Error_Printer("aaabbbbhaijjjm"));
            Console.WriteLine(Error_Printer("aaaxbbbbyyhwawiwjjjwwm"));
            Console.ReadLine();
        }

        static string Error_Printer(string s)
        {
            char[] includedLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
            char[] sToChar = s.ToCharArray();
            int errorCounter = 0;
            int totalChars = s.Length;
            string result;
            foreach (char c in sToChar)
            {
                if (!includedLetters.Contains(c))
                {
                    errorCounter++;
                }
            }
            result = errorCounter.ToString() + "/" + totalChars.ToString();
            return result;
        }
    }
}
