using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_alphabetwar
{
    class Kata
    {
        public static string AlphabetWar(string fight)
        {
            char[] fightToArray = fight.ToCharArray();
            int leftSideTotal = 0;
            int rightSideTotal = 0;
            foreach (char c in fightToArray)
            {
                switch (c)
                {
                    case 'w':
                        leftSideTotal += 4;
                        break;
                    case 'p':
                        leftSideTotal += 3;
                        break;
                    case 'b':
                        leftSideTotal += 2;
                        break;
                    case 's':
                        leftSideTotal += 1;
                        break;
                    case 'm':
                        rightSideTotal += 4;
                        break;
                    case 'q':
                        rightSideTotal += 3;
                        break;
                    case 'd':
                        rightSideTotal += 2;
                        break;
                    case 'z':
                        rightSideTotal += 1;
                        break;
                    default:
                        break;
                }
            }
            if (leftSideTotal > rightSideTotal)
            {
                return "Left side wins!";
            }
            else if (rightSideTotal > leftSideTotal)
            {
                return "Right side wins!";
            }
            else
            {
                return "Let's fight again!";
            }
        }

        // surprisingly, this one takes longer than the switch statement
        public static string AlphabetWar1(string fight)
        {
            var left = new Dictionary<char, int>() { { 'w', 4 }, { 'p', 3 }, { 'b', 2 }, { 's', 1 } };
            var right = new Dictionary<char, int>() { { 'm', 4 }, { 'q', 3 }, { 'd', 2 }, { 'z', 1 } };

            int leftTotal = 0;
            int rightTotal = 0;
            int result;
            //char[] fightCharacters = fight.ToCharArray();
            foreach (char c in fight)
            {
                if (left.TryGetValue(c, out result))
                {
                    leftTotal += result;
                }
                else
                {
                    right.TryGetValue(c, out result);
                    rightTotal += result;
                }
            }
            if (leftTotal > rightTotal)
            {
                return "Left side wins!";
            }
            else if (rightTotal > leftTotal)
            {
                return "Right side wins!";
            }
            else return "Let's fight again!";
        }
    }
}
