using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundByHalf
{
    public class Kata
    {
        // my solution
        public static double Solution(double n)
        {
            double floor = Math.Floor(n);
            double ceiling = Math.Ceiling(n);
            double half = ceiling - .5;
            if (n >= ceiling - .25) return ceiling;
            else if (n >= half - .25) return half;
            return floor;
        }

        // this was the best solution
        public static double Best(double n)
        {
            return Math.Round(n * 2) / 2;
        }
    }
}
