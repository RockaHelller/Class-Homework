using System;
using System.Collections.Generic;
using System.Text;

namespace TASK
{
    class Calculator
    {
        public int Calculate(int x, int y)
        {
            int result = 0;
            string n = Console.ReadLine();

            switch (n)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                default:
                    return result;

            }

            return result;

        }



    }
}
