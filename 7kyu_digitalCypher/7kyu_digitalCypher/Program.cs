using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Digital Cypher assigns to each letter of the alphabet unique number.
//Instead of letters in encrypted word we write the corresponding number, eg.The word scout:
//Then we add to each obtained digit consecutive digits from the key
//Write a function that accepts str string and key number and returns an array of integers representing encoded str.
//Input / Output

//The str input string consists of lowercase characters only.
//The key input number is a positive integer.
//Example

//Encode("scout",1939);  ==>  [ 20, 12, 18, 30, 21]
//Encode("masterpiece",1939);  ==>  [ 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8]

namespace _7kyu_digitalCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Encode("masterpiece", 1939);
            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }

        public static int[] Encode(string str, int n)
        {
            char[] inputArray = str.ToCharArray();
            int[] codeArray = new int[inputArray.Length];

            for(int i = 0; i < inputArray.Length; i++)
            {
                int value = inputArray[i] - 96;
                codeArray[i] = value;
            }

            // this is a cool way to convert an int to int[]
            int[] adder = n.ToString().Select(o => Convert.ToInt32(o -48)).ToArray();

            for (int j = 0; j < codeArray.Length; j++)
            {
                int adderIndex = j;
                int encodedNumber = codeArray[j];
                // this while loop took me awhile, i had it as an if initially
                while (adderIndex >= adder.Length)
                {
                    adderIndex -= adder.Length;
                }
                int numberToChange = adder[adderIndex];
                codeArray[j] = encodedNumber + numberToChange;
            }
            return codeArray;
        }
    }
}
