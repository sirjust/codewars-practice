using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rot13
{
    public static class Kata
    {
        public static string Rot13(string message)
        {
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = lowercase.ToUpper();
            int cipher = 13;
            StringBuilder builder = new StringBuilder();
            foreach(char c in message)
            {
                if (!lowercase.Contains(char.ToLower(c)))
                    {
                    builder.Append(c);
                    continue;
                };
                bool isLower = lowercase.Contains(c);
                int location = lowercase.IndexOf(char.ToLower(c));

                int newLocation = location + cipher;
                newLocation = newLocation >= lowercase.Length ? newLocation - lowercase.Length : newLocation;

                if (isLower) builder.Append(lowercase[newLocation]);
                else builder.Append(uppercase[newLocation]);
            }
            return builder.ToString();
        }
    }
}
