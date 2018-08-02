using System;


    class Program
    {
        static void Main(string[] args)
        {
        // this drill adds everything between and including the two numbers passed in, together
        Sumfunction sumfunction = new Sumfunction();

        //int result1 = sumfunction.Adder(0, 1);
        //int result2 = sumfunction.Adder(0, 5);
        int result3 = sumfunction.Adder(5, -2);
        int result4 = sumfunction.Adder(-5, -10);

        //Console.WriteLine(result1);
        //Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.ReadLine();
        }
    }

