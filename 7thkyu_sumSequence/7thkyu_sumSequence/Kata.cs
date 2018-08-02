using System;
using System.Collections.Generic;
using System.Text;

    public static class Kata
    {
        public static int SequenceSum(int start, int end, int step)
        {
        int sum = 0;
        if (start > end)
        {
            return 0;
        }
        while (start <= end)
        {
            sum += start;
            start += step;
        }
        return sum;
        }
    }

