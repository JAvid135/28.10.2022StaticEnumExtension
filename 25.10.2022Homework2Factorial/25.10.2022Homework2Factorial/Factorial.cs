using System;
using System.Collections.Generic;
using System.Text;

namespace _25._10._2022Homework2Factorial
{
    public static class Factorial
    {
        
        public static void FactorialCheck(this int number)
        {
            int result = 1;
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                    result *= i;
            }
            else
            {
                result = 0;
            }
            Console.WriteLine(result);
        }
    }
}
