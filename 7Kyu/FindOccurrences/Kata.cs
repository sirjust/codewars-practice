using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOccurrences
{
    public class Kata
    {
        public static int[] FindAll(int[] array, int n)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n) indexes.Add(i);
            }
            return indexes.ToArray();
        }
    }
}
