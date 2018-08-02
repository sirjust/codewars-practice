using System;
using System.Collections.Generic;
using System.Text;

    class CharSwap
    {
        public string Correct(string text)
        {
            var array1 = text.ToCharArray();
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == '0')
                {
                    array1[i] = 'O';
                }
                else if (array1[i] == '5')
                {
                    array1[i] = 'S';
                }
                else if (array1[i] == '1')
                {
                    array1[i] = 'I';
                }
            }
        text = new string(array1);
        return text;
        }
    }
