using System;
using System.Collections.Generic;
using System.Text;

namespace TASK
{
    class Factorial
    {
    int hasil = 1;
        public void FindFactorial(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                hasil *= i;
            }
            Console.WriteLine(hasil);
        }
    }
}
