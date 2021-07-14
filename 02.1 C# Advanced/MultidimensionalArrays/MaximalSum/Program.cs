using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the 3x3 square in a given N x M matrix that has maximal sum of its elements

            int[] matrixDimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowSize = matrixDimensions[0];
            int colSize = matrixDimensions[1];

            int[,] matrix = new int[rowSize, colSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }

            int resultMatrixSize = 3; // The searched matrix is 3x3 square matrix
            int maxElementsSum = 0;
            int resultMatrixStartRow = 0;
            int resultMatrixStartCol = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int elementsSum = 0;

                    for (int k = 0; k < resultMatrixSize; k++)
                    {
                        for (int l = 0; l < resultMatrixSize; l++)
                        {
                            elementsSum += matrix[i + k, j + l];
                        }
                    }

                    if (elementsSum > maxElementsSum)
                    {
                        maxElementsSum = elementsSum;
                        resultMatrixStartRow = i;
                        resultMatrixStartCol = j;
                    }
                }
            }

            // Print the sum of the elements of the 3x3 square 
            Console.WriteLine($"Sum = {maxElementsSum}");

            // Print the elements of the 3x3 square as a matrix
            for (int i = resultMatrixStartRow; i < resultMatrixStartRow + resultMatrixSize; i++)
            {
                for (int j = resultMatrixStartCol; j < resultMatrixStartCol + resultMatrixSize; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
