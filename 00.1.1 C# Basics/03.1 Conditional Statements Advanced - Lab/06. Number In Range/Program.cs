﻿using System;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number
            double number = double.Parse(Console.ReadLine());

            if (number >= -100 && number <= 100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
