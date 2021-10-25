using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Size of a square matrix as an input 
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            // Initialize the matrix
            for (int i = 0; i < size; i++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == i)
                    {
                        primaryDiagonalSum += matrix[i, j];
                    }

                    if (j == size - 1 - i)
                    {
                        secondaryDiagonalSum += matrix[i, j];
                    }
                }
            }

            // Print the absolute difference between
            // the sums of the primary and the secondary diagonal
            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));



            // Option 2
            // Without matrix 

            //int size = int.Parse(Console.ReadLine());            
            //int primaryDiagonalSum = 0;
            //int secondaryDiagonalSum = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    int[] rowElements = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //        .Select(int.Parse)
            //        .ToArray();

            //    for (int j = 0; j < rowElements.Length; j++)
            //    {
            //        if (j == i)
            //        {
            //            primaryDiagonalSum += rowElements[j];
            //        }

            //        if (j == size - 1 - i)
            //        {
            //            secondaryDiagonalSum += rowElements[j];
            //        }
            //    }
            //}

            //Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}