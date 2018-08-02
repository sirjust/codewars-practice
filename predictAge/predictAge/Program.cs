using System;

//My grandfather always predicted how old people would get, and right before he passed away he revealed his secret!
//In honor of my grandfather's memory we will write a function using his formula!
//    Take a list of ages when each of your great-grandparent died.
//    Multiply each number by itself.
//    Add them all together.
//    Take the square root of the result.
//    Divide by two.

namespace predictAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = PredictAge(80, 50, 75, 60, 68, 90, 55, 67);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
        {
            int total = 0;
            int[] ageArray = new int[] { age1, age2, age3, age4, age5, age6, age7, age8 };
            foreach(int age in ageArray)
            {
                total = total + (age * age);
            }
            total = (int)System.Math.Sqrt(total);
            total /= 2;
            return total;
        }
    }
}
