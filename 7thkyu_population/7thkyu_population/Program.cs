using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _7thkyu_population
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = NbYear(1500000, 0, 10000, 2000000);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int years;
            int newPop = p0;
            double percentageCalc = (percent /100);
            for (years = 0; newPop < p; years++)
            {
                newPop += (int)Math.Floor((newPop * (percentageCalc)) + aug);
            }
            return years;
        }
    }
}
