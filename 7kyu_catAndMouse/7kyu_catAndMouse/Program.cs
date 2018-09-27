using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_catAndMouse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Kata.CatMouse("C....m"));
            Console.Read();
        }

        public class Kata
        {
            public static string CatMouse(string x)
            {
                char[] myArray = x.ToCharArray();
                char cat = 'C';
                char mouse = 'm';
                int catNumber = 0;
                int mouseNumber = 0;

                for (int i = 0; i < myArray.Length; i++){
                    if (myArray[i] == cat)
                    {
                        catNumber = i;
                    }
                    if (myArray[i]== mouse)
                    {
                        mouseNumber = i;
                    }
                    else
                    {
                        continue;
                    }
                }
                int result = Math.Abs(mouseNumber - catNumber);
                if (result < 4)
                {
                    return "Caught!";
                }
                else
                {
                    return "Escaped!";
                }
            }
        }
    }
}
