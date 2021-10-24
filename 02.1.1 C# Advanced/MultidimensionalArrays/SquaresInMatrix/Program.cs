using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the number of 2x2 squares of equal characters in a given matrix

            int[] matrixDimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowSize = matrixDimensions[0];
            int colSize = matrixDimensions[1];

            char[,] matrix = new char[rowSize, colSize];

            for (int i = 0; i < rowSize; i++)
            {
                // The number of elements in a row given as an input
                // should be the same as the number of columns of the matrix
                char[] rowElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < colSize; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }

            int equalCharSquaresCounter = 0;

            for (int i = 0; i < rowSize - 1; i++)
            {
                for (int j = 0; j < colSize - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j] &&
                        matrix[i, j] == matrix[i+1, j+ 1])
                    {
                        equalCharSquaresCounter++; 
                    }
                }
            }

            // Print the number of all the 2x2 squares of equal characters found
            Console.WriteLine(equalCharSquaresCounter);
        }
    }
}