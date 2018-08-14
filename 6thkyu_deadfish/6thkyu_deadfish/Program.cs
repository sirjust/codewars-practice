using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6thkyu_deadfish
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Parse("iiisdoso");
            Console.WriteLine(string.Join(",", result));
            Console.ReadLine();
        }

            public static int[] Parse(string data)
            {
                int[] outputArray = new int[0];
                int myNumber = 0;
                char[] splitData = data.ToCharArray();
                foreach (char c in splitData)
                {
                    switch (c)
                    {
                        case ('i'):
                            myNumber++;
                            continue;
                        case ('d'):
                            myNumber--;
                            continue;
                        case ('s'):
                            myNumber *= myNumber;
                            continue;
                        case ('o'):
                            Array.Resize(ref outputArray, outputArray.Length + 1);
                            outputArray[outputArray.Length - 1] = myNumber;
                            continue;
                        default:
                            continue;
                    }
                }
                return outputArray;
            }
        }
    }
