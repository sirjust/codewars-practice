using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu_areTheySame
{
    public class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            Array.Sort(a);
            Array.Sort(b);

            int length = a.Length;
            int[] aSquared = new int[length];

            if (b.Length != length)
            {
                return false;
            }

            for(int i = 0; i<length; i++)
            {
                int thisNum = a[i];
                int numSquared = thisNum * thisNum;
                aSquared[i] = numSquared;
            }

            for(int i = 0; i < length; i++)
            {
                if (aSquared[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
