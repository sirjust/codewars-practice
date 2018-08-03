using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//If I give you a name of a city as a string, I want you to return a string that shows how many times each letter shows up in the string by using an asterisk*

//SEE TEST CASE!

//As you can see for Chicago, in the return string, I only show the letter "c" once even though there are 2 "c" in Chicago(regardless of upper or lowercase).

//I show 2 asteriks since there are 2 "c" in Chicago.

//In the return string there are no spaces between the letters, asteriks, and commas.

//GetStrings("Chicago") => "c:**,h:*,i:*,a:*,g:*,o:*"
//Note that the return string contains the characters in order of first appearence in the original string.

//HAVE FUN!! ;)

namespace _7thkyuInterviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetStrings("Las Vegas");
            Console.WriteLine(result);
            Console.Read();
        }

        public static string GetStrings(string city)
        {
            string newCity = Regex.Replace(city, @"\s+", "");
            var cityList = newCity.ToLower().ToList();
            var letterList = cityList.Distinct().ToList();
            List<string> finalList = new List<string>();
            foreach (char letter in letterList)
            {
                finalList.Add(letter.ToString());
            }
            for (int i = 0; i < letterList.Count; i++)
            {
                finalList[i] = finalList[i] + ":";
                foreach(char letter in cityList)
                {
                    if (finalList[i].Contains(letter.ToString()))
                    {
                        finalList[i] = finalList[i] + "*";
                    }
                }
            }

            string result = string.Join(",", finalList);
            return result;
        }
    }
}
