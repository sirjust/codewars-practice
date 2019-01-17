using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu_TicketClerk
{
    public class Line
    {
        public static string Tickets(int[] peopleInLine)
        {
            Dictionary<int, int> bank = new Dictionary<int, int>();

            bank.Add(100, 0);
            bank.Add(50, 0);
            bank.Add(25, 0);

            int ticketPrice = 25;
            int change;
            foreach(int customerBill in peopleInLine)
            {
                bank[customerBill]++;
     
                change = customerBill - ticketPrice;
                while(change > 0)
                {
                    try
                    {
                        for(int index = 0; index < bank.Count; index++)
                        {
                            var item = bank.ElementAt(index);
                            var itemKey = item.Key;
                            var itemValue = item.Value;
                            if (itemValue>0 && change - itemKey >= 0)
                            {
                                change -= itemKey;
                                itemValue--;
                            }
                        }
                    }
                    catch
                    {
                        return "NO";
                    }
                }
            }
            return "YES";
        }
    }
}
