using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_minmax
{
    class Kata
    {
        public int Min(int[] list)
        {
            var newList = list.ToList();
            int min = newList.Min();
            return min;
        }

        public int Max(int[] list)
        {
            var newList = list.ToList();
            int max = newList.Max();
            return max;
        }
    }
}
