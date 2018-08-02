using System;

    class Program
    {
        static void Main(string[] args)
        {
        double result1 = Calculator.Calculate('+', 13, 7);
        double result2 = Calculator.Calculate('-', 200, 3.7);
        double result3 = Calculator.Calculate('*', 3.5, 77);
        double result4 = Calculator.Calculate('/', 100, 5);
        Console.WriteLine("{0} {1} {2} {3}", result1, result2, result3, result4);
        Console.ReadLine();
        }
    }
