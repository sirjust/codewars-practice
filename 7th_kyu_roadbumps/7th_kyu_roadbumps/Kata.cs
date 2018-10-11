using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_kyu_roadbumps
{
    class Kata
    {
        public static string Bump(string input)
        {
            char[] myArray = input.ToCharArray();
            int counter = 0;
            foreach (char x in myArray)
            {

                if (x == 'n')
                {
                    counter++;
                }
            }
            if (counter < 15)
            {
                return "Woohoo!";
            }
            else
            {
                return "Car Dead";
            }
        }
    }
}

