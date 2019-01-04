using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_MyLanguages
{
    public static class Kata
    {
        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            IEnumerable<KeyValuePair<string, int>> overSixty = results.Where(kv => kv.Value >= 60).OrderByDescending(kv => kv.Value);

            List<string> list = new List<string>();

            foreach(var item in overSixty)
            {
                list.Add(item.Key);
            }
            return list;
        }
    }
}