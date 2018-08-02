using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_kata_even_odd
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 2;
            int y = 35;
            int z = 0;

            string result1 = SolutionClass.EvenOrOdd(x);
            string result2 = SolutionClass.EvenOrOdd(y);
            string result3 = SolutionClass.EvenOrOdd(z);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
