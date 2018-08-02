using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_kata_find_smallest
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] first = new int[6] { 78, 56, 232, 12, 11, 43 };
            int[] second = new int[6] { 78, 56, -2, 12, 8, -33 };
            Kata kata = new Kata();

            int result1 = kata.FindSmallestInt(first);
            int result2 = kata.FindSmallestInt(second);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
