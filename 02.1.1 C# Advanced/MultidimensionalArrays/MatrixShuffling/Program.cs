using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowSize = matrixDimensions[0];
            int colSize = matrixDimensions[1];

            string[,] matrix = new string[rowSize, colSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] rowInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowInput[j];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToUpper() == "END")
                {
                    return;
                }

                string[] commandTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Command is in the format "swap row1 col1 row2 col2"
                int validNumberOfTokens = 5;

                if (commandTokens.Length != validNumberOfTokens)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string command = commandTokens[0];
                int firstElementRow = int.Parse(commandTokens[1]);
                int firstElementCol = int.Parse(commandTokens[2]);
                int secondElementRow = int.Parse(commandTokens[3]);
                int secondElementCol = int.Parse(commandTokens[4]);

                // Check if the command is valid
                // - contains the keyword "swap",
                // - has the exact number of coordinates entered or
                // - the given coordinates exist 
                if (command != "swap" ||
                    firstElementRow < 0 || firstElementRow > rowSize ||
                    firstElementCol < 0 || firstElementCol > colSize ||
                    secondElementRow < 0 || secondElementRow > rowSize ||
                    secondElementCol < 0 || secondElementCol > colSize)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                // Swap the values at the given coordinates
                string temp = matrix[firstElementRow, firstElementCol];
                matrix[firstElementRow, firstElementCol] = matrix[secondElementRow, secondElementCol];
                matrix[secondElementRow, secondElementCol] = temp;

                // Print the current formation of the matrix
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }

                    Console.WriteLine();
                }                
            }
        }
    }
}
