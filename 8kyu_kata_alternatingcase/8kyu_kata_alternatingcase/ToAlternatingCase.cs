using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_kata_alternatingcase
{
    class ToAlternatingCase
    {
        public string AlternatingCase(string input)
        {
            char[] array = input.ToCharArray();
            char[] array1 = new char[array.Length];
            char newItem;
            int index = 0;
            foreach (char item in array)
            {
                bool isLower = char.IsLower(item);
                if (isLower)
                {
                    newItem = char.ToUpper(item);
                }
                else
                {
                     newItem = char.ToLower(item);
                }
                array1[index] = newItem;
                index++;
            }
            string newString = new string(array1);
            return newString;
        }
    }
}
