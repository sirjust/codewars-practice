using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_checkFlush
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards1 = new string[] {"AS", "3S", "9S", "KS", "4S"};
            string[] cards2 = new string[] { "AD", "4S", "7H", "KS", "10S" };
            Console.WriteLine(CheckIfFlush(cards1));
            Console.WriteLine(CheckIfFlush(cards2));
            Console.Read();
        }

        public static bool CheckIfFlush(string[] cards)
        {
            string[] options = new string[] { "S", "H", "C", "D" };
            string firstCard = cards[0];
            bool isFlush = true;
            foreach (string s in options)
            {
                if (firstCard.Contains(s)){
                    foreach(string st in cards)
                    {
                        if (!st.Contains(s)){
                            isFlush = false;
                            break;
                        }
                    }
                }
                else { continue; }
            }
            return isFlush;
        }
    }
}
