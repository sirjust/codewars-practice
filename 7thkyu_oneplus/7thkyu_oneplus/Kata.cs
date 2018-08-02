<<<<<<< HEAD
﻿namespace _7thkyu_oneplus
{
    // my original thought was to make an array and then iterate. Though it worked, it took
    // over 12 seconds, and didn't pass the test. I then simplified it by adding the numbers
    // during the while loop, which passed the test in 8 seconds.
    class Kata
    {
        public static long? RangeSum(long n)
        {
            long sum = 0;
            if (n <= 0)
            {
                return null;
            }
            else
            {
                //int[] myArray = new int[n+1];
                while (n > 0)
                {
                    sum += n; // this takes the place of the for loop
                    n--;
                }
                //for (int i = 0; i < myArray.Length-1; i++)
                //{
                //    sum = sum + myArray[i + 1];
                //}
                return sum;
            }
        }
    }
}
=======
﻿namespace _7thkyu_oneplus
{
    // my original thought was to make an array and then iterate. Though it worked, it took
    // over 12 seconds, and didn't pass the test. I then simplified it by adding the numbers
    // during the while loop, which passed the test in 8 seconds.
    class Kata
    {
        public static long? RangeSum(long n)
        {
            long sum = 0;
            if (n <= 0)
            {
                return null;
            }
            else
            {
                //int[] myArray = new int[n+1];
                while (n > 0)
                {
                    sum += n; // this takes the place of the for loop
                    n--;
                }
                //for (int i = 0; i < myArray.Length-1; i++)
                //{
                //    sum = sum + myArray[i + 1];
                //}
                return sum;
            }
        }
    }
}
>>>>>>> 07c2279c3d347da6343717f8d8768ef42ae0f2e2
