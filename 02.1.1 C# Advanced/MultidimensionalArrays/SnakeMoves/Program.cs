using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            // Visualize a snake's path of a string in a NxM matrix form
            // until it fills the matrix, if you reach the end of the string
            // representing the snake, start again at the beginning

            int[] matrixDimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            // The dimensions N and M of the matrix will be integers in the range [1...12]
            int rowSize = matrixDimensions[0];
            int colSize = matrixDimensions[1];
            char[,] matrix = new char[rowSize, colSize];

            // The string that follows a snake's path is with length in the range [1...20] and
            // will not contain any whitespace characters
            string text = Console.ReadLine();
            int currentChar = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        currentChar = currentChar % text.Length;
                        matrix[i, j] = text[currentChar];
                        currentChar++;
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        currentChar = currentChar % text.Length;
                        matrix[i, j] = text[currentChar];
                        currentChar++;
                    }
                }
            }

            // Print the matrix representing the snake's path
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
