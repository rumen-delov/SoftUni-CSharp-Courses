﻿using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = Sum(firstNumber, secondNumber);
            int diff = Subtract(sum, thirdNumber);

            Console.WriteLine(diff);
        }

        private static int Subtract(int first, int second)
        {
            return first - second;
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
