using System;
using System.ComponentModel.DataAnnotations;

namespace EqualSumsOnOddAndEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read two six-digit numbers
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string currentNumber = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString()); // It uses .ToString() cause it cannot get parsed from char to int
                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
