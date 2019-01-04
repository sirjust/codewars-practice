using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_banjo
{
    class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
            char[] nameChars = name.ToCharArray();
            if (nameChars[0] == 'R' || nameChars[0] == 'r')
            {
                return name + " plays banjo";
            }
            else
            {
                return name + " does not play banjo";
            }
        }
    }
}
