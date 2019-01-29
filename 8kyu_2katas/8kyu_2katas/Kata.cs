using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_2katas
{
    public static class Kata
    {
        public static int Enough(int cap, int on, int wait)
        {
            int totalPassengers = on + wait;
            if (totalPassengers > cap)
            {
                return totalPassengers - cap;
            }
            else return 0;
        }


        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 || projects > 10)
            {
                return 100;
            }
            else if (exam > 75 && projects >= 5)
            {
                return 90;
            }
            else if (exam > 50 && projects >= 2)
            {
                return 75;
            }
            else return 0;
        }
    }
}
