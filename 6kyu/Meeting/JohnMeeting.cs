using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    public class JohnMeeting
    {
        // s = "Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";

        //  Could you make a program that

        //  1. makes this string uppercase
        //  2. gives it sorted in alphabetical order by last name.
        //  3. When the last names are the same, sort them by first name.Last name and first name of a guest come in the result between parentheses separated by a comma.

        //  example result: "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)"
        public static string Meeting(string s)
        {
            List<string> fullNames = s.Split(';').ToList<string>();
            List<Person> personList = new List<Person>();
            foreach (string fullName in fullNames)
            {
                string[] splitNames = fullName.Split(':');
                string firstName = splitNames[0].ToUpper();
                string lastName = splitNames[1].ToUpper();
                Person person = new Person { FirstName = firstName, LastName = lastName };
                personList.Add(person);
            }
            personList = personList.OrderBy(x => x.LastName).ThenBy(x=> x.FirstName).ToList();
            StringBuilder builder = new StringBuilder();
            foreach (Person person in personList)
            {
                builder.Append($"({person.LastName}, {person.FirstName})");
            }
            return builder.ToString();
        }
            class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
