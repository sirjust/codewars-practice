using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();

            var first = new int[8] { 4, 6, 2, 1, 9, 63, -134, 566 };
            var second = new int[7] { -52, 56, 30, 29, -54, 0, -110 };
            var third = new int[1] { 5 };
            var fourth = new int[5] { 42, 54, 65, 87, 0 };

            Console.WriteLine(first.Max());
            Console.WriteLine(second.Min());
            Console.WriteLine(third.Max());
            Console.WriteLine(fourth.Min());
            Console.ReadLine();
        }
    }
}
