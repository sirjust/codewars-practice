using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a function that receives one argument n, as an upper limit, and the return the following array:

//[number_of_emirps_below_n, largest_emirp_below_n, sum_of_emirps_below_n]

//Examples
//find_emirp(10)
//[0, 0, 0] ''' no emirps below 10 '''

//find_emirp(50)
//[4, 37, 98] ''' there are 4 emirps below 50: 13, 17, 31, 37; largest = 37; sum = 98 '''

//find_emirp(100)
//[8, 97, 418] ''' there are 8 emirps below 100: 13, 17, 31, 37, 71, 73, 79, 97; largest = 97; sum = 418 '''


namespace _5kyu_emirps
{
    class Program
    {
        // brute force method, it passes the tests but takes too long
        static void Main()
        {
            long[] display = Emirps.DetermineEmirps(750);
            foreach (long i in display)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
