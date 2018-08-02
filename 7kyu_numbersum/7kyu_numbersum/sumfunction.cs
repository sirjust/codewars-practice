using System;
using System.Collections.Generic;
using System.Text;


    public class Sumfunction
    {

    public int Adder (int a, int b)
    {
        int newnum1;
        int newnum2;
        int sum = 0;

        // if they are the same, return one or the other
        if (a == b)
        {
            return a;
        }
        else if (a < b)
        {
            newnum1 = a;
            newnum2 = b;
        }
        // if they are out of order, i need to reorder them from smallest to greatest
        else
        {
            newnum1 = b;
            newnum2 = a;
        }
        List<int> list = new List<int>();
        // here i create a list of every integer in between the two numbers and including them
        for (int i = newnum1; i <= newnum2; i++)
        {
            list.Add(i);
        }

        // here i add each value to sum
        for(int j = 0; j < list.Count -1; j++)
        {
            if (j==0)
            {
                sum = list[j] + list[j + 1];
            }
            else
            {
                sum = sum + list[j + 1];
            }
        }
        return sum;
    }
    }
