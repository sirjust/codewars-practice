using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageArray
{
    public static class Kata
    {
        // Create a function that takes a 2D array as an input, and outputs another array that contains the average values for the numbers in the nested arrays at the corresponding indexes.

        // avgArray([[1, 2, 3, 4], [5, 6, 7, 8]]); // => [3, 4, 5, 6]
        // avgArray([[2, 3, 9, 10, 7], [12, 6, 89, 45, 3], [9, 12, 56, 10, 34], [67, 23, 1, 88, 34]]); // => [22.5, 11, 38.75, 38.25, 19.5]
        public static double[] AvgArray(double[][] arr)
        {
            double[] result = new double[arr[0].Length];
            for(int i = 0; i < arr[0].Length; i++)
            {
                int j = arr.Length -1;
                double num = arr[j][i];
                while (j > 0)
                {
                    num += arr[j - 1][i];
                    j--;
                }
                result[i] = num/(arr.Length);
            }
            return result;
        }
    }
}
