using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We need to write some code to return the original price of a product, the return type must be of type decimal and 
//    the number must be rounded to two decimal places.

//We will be given the sale price (discounted price), and the sale percentage, our job is to figure out the original price.

//For example:
//Given an item at $75 sale price after applying a 25% discount, the function should return the original price of that item 
//        before applying the sale percentage, which is ($100.00) of course, rounded to two decimal places.

//DiscoverOriginalPrice(75, 25) => 100.00M where 75 is the sale price(discounted price), 25 is the sale percentage and 100 is 
//the original price

namespace _7kyu_originalPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DiscoverOriginalPrice(75.00M, 25.00M));
            Console.WriteLine(DiscoverOriginalPrice(45.00M, 10.00M));
            Console.Read();
        }

        public static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage)
        {
            decimal PricePercent = 100.00M - salePercentage;
            decimal pretotal = (discountedPrice * 100) / PricePercent;
            decimal total = Math.Round(pretotal, 2);

            return total;
        }
    }
}
