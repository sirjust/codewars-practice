using System;

namespace _8kyu_stringRepeat
{
    // this kata takes an integer (n) and a string
    // it repeats the given string string exactly n times.
    class Program
    {
        static void Main(string[] args)
        {
            string result = Kata.repeatStr(4, "hello");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
