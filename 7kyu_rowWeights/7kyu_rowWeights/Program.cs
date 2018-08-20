using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_rowWeights
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 0, 1, 0 };
            Console.WriteLine(string.Join(" ", RowWeights(input)));
            Console.Read();
        }

        public static int[] RowWeights(int[] a)
        {
            int[] answer = new int[2] { 0, 0 };

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    answer[0] += a[i];
                }
                else
                {
                    answer[1] += a[i];
                }
            }
            return answer;
        }
    }
}
