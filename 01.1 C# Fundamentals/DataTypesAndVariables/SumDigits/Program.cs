﻿using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            
            // Finding all digits of a number
            // and computing their sum
            while (number > 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }
            
            Console.WriteLine(sum);
        }
    }
}
