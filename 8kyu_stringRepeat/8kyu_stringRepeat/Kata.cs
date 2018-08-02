using System;
using System.Collections.Generic;
using System.Text;

namespace _8kyu_stringRepeat
{ 
    public class Kata
    {
        public static string repeatStr(int n, string s)
        {
            string newString = s;
            while (n > 1)
            {
                newString = newString + s;
                n--;
            }
            return newString;
        }
    }
}

