using System;

namespace PyramidOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the integer number 
            int inputNumber = int.Parse(Console.ReadLine());

            int currentPyramidNumber = 1;
            bool isLarger = false;

            for (int rows = 1; rows <= inputNumber; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    if (currentPyramidNumber > inputNumber)
                    {
                        isLarger = true;
                        break;
                    }
                    Console.Write($"{currentPyramidNumber} ");
                    currentPyramidNumber++;
                }
                if (isLarger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
