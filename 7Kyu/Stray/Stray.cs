using System.Linq;

namespace Stray
{
    public static class Kata
    {
        public static int Stray(int[] numbers)
        {
            if(numbers[0] == numbers[1])
            {
                return numbers.Where(c => c != numbers[0]).FirstOrDefault();
            }
            else
            {
                return numbers.Where(c => c != numbers[2]).FirstOrDefault();
            }
        }
    }
}
