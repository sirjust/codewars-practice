using System;
using System.Collections.Generic;
using System.Text;

    class Calculator
    {
        public static double Calculate(char operation, double value1, double value2)
    {
        bool correct = false;
        double answer = 0;
        while(!correct)
        {
            string opString = operation.ToString();
            if (opString == "+")
            {
                correct = true;
                answer = value1 + value2;
            }
            else if (opString == "-")
            {
                correct = true;
                answer = value1 - value2;
            }
            else if (opString == "*")
            {
                correct = true;
                answer = value1 * value2;
            }
            else if (opString == "/")
            {
                correct = true;
                answer = value1 / value2;
            }
        }
        return answer;
    }
    }
