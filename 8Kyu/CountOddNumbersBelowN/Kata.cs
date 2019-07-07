using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOddNumbersBelowN
{
    public static class Kata
    {
        // Given a number n, return the number of positive odd numbers below n, EASY!
        public static ulong OddCount(ulong n)
        {
            return n / 2;
        }
    }
}
