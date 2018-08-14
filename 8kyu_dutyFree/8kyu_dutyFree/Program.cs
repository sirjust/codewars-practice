using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//how many bottles of duty free liquor do you need to make your holiday worth it/
//

namespace _8kyu_dutyFree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DutyFree(12,50,1000));
            Console.ReadLine();
        }

        public static int DutyFree(int normPrice, int Discount, int hol)
        {
            double savePrice = normPrice * (.01 * Discount);
            double result = Math.Floor((double)hol / savePrice);
            return (int)result;
        }
    }
}
