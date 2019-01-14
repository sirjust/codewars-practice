using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_DigitalCypher2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            Console.WriteLine(Kata.Decode(new int[] { 20, 12, 18, 30, 21 }, 1939));
            Console.Read();
        }
    }
}
