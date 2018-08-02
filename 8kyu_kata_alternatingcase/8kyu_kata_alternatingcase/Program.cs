using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_kata_alternatingcase
{
    class Program
    {
        static void Main(string[] args)
        {
            ToAlternatingCase toAlternating = new ToAlternatingCase();

            string result1 = toAlternating.AlternatingCase("hello world");
            string result2 = toAlternating.AlternatingCase("HELLO WORLD");
            string result3 = toAlternating.AlternatingCase("hello WORLD");
            string result4 = toAlternating.AlternatingCase("HeLLo WoRLD");
            string result5 = toAlternating.AlternatingCase("12345");
            string result6 = toAlternating.AlternatingCase("1a2b3c4d5e");
            string result7 = toAlternating.AlternatingCase("String.ToAlternatingCase");

            Console.WriteLine(result1 + "\n" + result2 + "\n" + result3 + "\n" + result4 + "\n" + result5 + "\n" + result6 + "\n" + result7);
            Console.ReadLine();
        }
    }
}
