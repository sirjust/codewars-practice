using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this kata removes all instances of the second array from the first
// i turned the first into a list and iterated through it, making sure to go to the beginning if i had removed a value
// the algorithm timed out on codewars, so my implementation is not efficient enough

// perhaps it is time to really focus on lambdas

namespace _6thkyu_removeFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = ArrayDiff(new int[] { 1, 2, 2, 3,4,5,6,7,7,7,7,7,7,7,7 }, new int[] { 2,7 });
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var toList = a.ToList();
            bool removed = false;
            for(int i = 0; i< toList.Count; i++)
            {
                removed = false;
                if (b.Contains(toList[i])){
                    toList.Remove(toList[i]);
                    removed = true;
                }
                if (removed)
                {
                    i = 0;
                }
            }
            return toList.ToArray();
        }
    }
}
