using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_kyu_roadbumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string result1 = Kata.Bump("n");
            string result2 = Kata.Bump("_nnnnnnn_n__n______nn__nn_nnn");
            string result3 = Kata.Bump("______n___n_");

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
    }
    }
}
