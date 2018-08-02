using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_kata_find_smallest
{
    class Kata
    {
        public int FindSmallestInt(int[] args)
        {
            int smallest = args[0];
            foreach (int x in args)
            {
                if(smallest >= x)
                {
                    smallest = x;
                }
            }
            return smallest;
        }
    }
}
