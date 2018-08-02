using System;

namespace _7thkyu_beach
{
    class Program
    {
        static void Main(string[] args)
        {
            // this algorithm returns the number of times certain words occur in a given string
            // due to a large amount of repeated code, I will try again later with Regex
            int result1 = Kata.SumOfABeach("WAtErSlIde");
            int result2 = Kata.SumOfABeach("GolDeNSanDyWateRyBeaChSuNN");
            int result3 = Kata.SumOfABeach("gOfIshsunesunFiSh");
            int result4 = Kata.SumOfABeach("cItYTowNcARShoW");
            int result5 = Kata.SumOfABeach("sunsunsunsun");

            Console.WriteLine(result1 + " " + result2 + " " + result3 + " " + result4 + " " + result5);
            Console.ReadLine();
        }
    }
}
