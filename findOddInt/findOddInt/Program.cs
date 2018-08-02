using System;

namespace findOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
            Console.WriteLine(result);
            Console.ReadLine();
        }

    public static int Find_it(int[] seq)
        {
            for(int i= 0; i< seq.Length; i++)
            {
                int num1 = seq[i];
                int counter = 0;
                for(int j = 0; j < seq.Length; j++)
                {
                    int num2 = seq[j];
                    if (num1 == num2)
                    {
                        counter++;
                    }
                }
                if (counter % 2 == 1)
                {
                    return num1;
                }
            }
            return 0;
        }
    }
}

