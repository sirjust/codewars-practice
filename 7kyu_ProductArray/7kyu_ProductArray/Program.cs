using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

// return an array where each element is the product of all elements except the 
// corresponding one in the argument

namespace _7kyu_ProductArray
{
    public class Program
    {
        public static int[] ProductArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int toInsert = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        toInsert *= 1;
                    }
                    else
                    {
                        toInsert *= array[j];
                    }
                }
                newArray[i] = toInsert;
            }
            return newArray;
        }

        static void Main(string[] args) { }

    }
}


// this works on all practice tests and all test I have come up with, including negatives and zeroes
// the final test in codewars (which I don't have acces to) results in a fail:

// Expected: -32418  But was:  47932
// Expected: -31514  But was:  1326684368
// Expected: -23165  But was:  -90291328
// Expected: -1019   But was:  551623688


