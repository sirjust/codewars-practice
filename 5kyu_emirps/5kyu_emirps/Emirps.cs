using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5kyu_emirps
{
    static class Emirps
    {
        public static long[] DetermineEmirps(long inputNumber)
        {
            long[] emirpsArray = new long[inputNumber];
            int counter = 0;
            for(long i = 3; i<= inputNumber; i++)
            {
                if (emirpsArray.Contains(i))
                {
                    continue;
                }
                if (IsPrime(i) == true && i>10)
                {
                    long iReversed = reverselong(i);
                    if (iReversed == i)
                    {
                        continue;
                    }
                    if (IsPrime(iReversed))
                    {
                        if (iReversed <= inputNumber)
                        {
                            emirpsArray[counter] = i;
                            counter++;
                            emirpsArray[counter] = iReversed;
                            counter++;
                        }
                        else
                        {
                            emirpsArray[counter] = i;
                            counter++;
                        }
                    }
                }
            }
            Array.Resize(ref emirpsArray, counter);
            // we have to subtract for these values because it incremented after the last time
            Array.Sort(emirpsArray);
            long total = counter;
            long largest = emirpsArray[counter-1];
            long sum = sumEmirps(emirpsArray);
            long[] desiredReturn = new long[3] { total, largest, sum };
            return desiredReturn;
        }

        public static bool IsPrime(long numberInQuestion)
        {
            if (numberInQuestion <= 1)
                return false;
            else if (numberInQuestion % 2 == 0)
                return numberInQuestion == 2;

            long N = (long)(Math.Sqrt(numberInQuestion) + 0.5);

            for (long i = 3; i <= N; i += 2)
                if (numberInQuestion % i == 0)
                    return false;
            return true;
        }

        public static long reverselong(long numberToReverse)
        {
            long Reverse = 0;
            while (numberToReverse > 0)
            {
                long remainder = numberToReverse % 10;
                Reverse = (Reverse * 10) + remainder;
                numberToReverse = numberToReverse / 10;
            }
            return Reverse;
        }

        public static long sumEmirps(long[] ArrayToAdd)
        {
            long sum = 0;
            foreach (long i in ArrayToAdd)
            {
                sum += i;
            }
            return sum;
        }
    }
}
