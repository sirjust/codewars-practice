using System;

namespace _7thkyu_driverslicense
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "John", "James", "Smith", "01-Jan-2000", "M" };
            string[] data1 = { "Andrew", "Robert", "Lee", "02-September-1981", "M" };
            string answer = Kata.Driver(data1);
            string answer1 = Kata.Driver(data);
            Console.WriteLine(answer);
            Console.WriteLine(answer1);
            Console.ReadLine();
        }
    }
}
