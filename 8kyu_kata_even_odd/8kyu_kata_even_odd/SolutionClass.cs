using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_kata_even_odd
{
    class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            string evenorodd;
            if (number % 2 == 0)
            {
                evenorodd = "Even";
            }
            else
            {
                evenorodd = "Odd";
            }
            return evenorodd;
        }
    }
}
