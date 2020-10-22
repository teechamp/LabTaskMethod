﻿using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Please enter the value of the base: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter thr value of an exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            int totalCal = IntegerPower(baseNum, exponent);
            Console.WriteLine("{0} to the power of {1} is {2}", baseNum, exponent, totalCal);
        }

        private static int IntegerPower(int baseNum, int expo)
        {
            var result = 1;
            for (var i = 0; i < expo; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
