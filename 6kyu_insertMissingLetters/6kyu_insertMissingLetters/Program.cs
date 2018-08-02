using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In this Kata you have to create a function, named insertMissingLetters, that takes in a string and outputs the same string processed in a particular way.

//The function should insert only after the first occurence of each character of the input string, all the alphabet letters that:

//-are NOT in the original string
//-come after the letter of the string you are processing

//Each added letter should be in uppercase, the letters of the original string will always be in lowercase.

//Example:

//input: "holly"

//missing letters: "a,b,c,d,e,f,g,i,j,k,m,n,p,q,r,s,t,u,v,w,x,z"

//output: "hIJKMNPQRSTUVWXZoPQRSTUVWXZlMNPQRSTUVWXZlyZ"

//You don't need to validate input, the input string will always contain a certain amount of lowercase letters (min 1 / max 50).


namespace _6kyu_insertMissingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "holly";
            Console.WriteLine(InsertMissingLetters(input));
            Console.ReadLine();
        }

        public static string InsertMissingLetters(string str)
        {
            List<char> uppercaseLetters = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] letterArray = str.ToUpper().ToCharArray();
            List<char> resultList = new List<char>();
            foreach (char c in letterArray)
            {
                // resultList.Add(char.ToLower(c));
                for(int i = 0; i <uppercaseLetters.Count; i++)
                {
                    if (c == uppercaseLetters[i])
                    {
                        uppercaseLetters.Remove(uppercaseLetters[i]);
                    }
                }
            }
            foreach (char c in letterArray)
            {
                if (resultList.Contains(char.ToLower(c)))
                {
                    resultList.Add(char.ToLower(c));
                    continue;
                }
                resultList.Add(char.ToLower(c));
                bool addToList = false;
                for (int i = 0; i < uppercaseLetters.Count; i++)
                {
                    if (c == (uppercaseLetters[i] - 1))
                    {
                        addToList = true;
                    }
                    if (addToList)
                    {
                        resultList.Add(uppercaseLetters[i]);
                    }
                }
            }
            string result = string.Join("", resultList);
            return result;
        }
    }
}
