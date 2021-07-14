using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine()); // integer in the range [2...12]
            double[][] jagged = new double[rowSize][];

            // Populate the jagged matrix
            for (int i = 0; i < jagged.Length; i++)
            {
                int[] rows = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jagged[i] = new double[rows.Length];

                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = rows[j];
                }
            }

            // If a row and the one below it have equal length,
            // multiply each element in both of them by 2,
            // otherwise - divide by 2    
            for (int i = 0; i < jagged.Length - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] /= 2;                        
                    }

                    for (int j = 0; j < jagged[i + 1].Length; j++)
                    {
                        jagged[i + 1][j] /= 2;
                    }
                }
            }

            // Process the commands
            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToUpper() == "END")
                {
                    break;
                }

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                int rowIndex = int.Parse(tokens[1]);
                int colIndex = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                // Check if the row and column indices are valid
                if (rowIndex < 0 ||
                    rowIndex >= jagged.Length ||
                    colIndex < 0 ||
                    colIndex >= jagged[rowIndex].Length)
                {
                    continue;
                }

                switch (command.ToUpper())
                {
                    case "ADD":
                        jagged[rowIndex][colIndex] += value;
                        break;
                    case "SUBTRACT":
                        jagged[rowIndex][colIndex] -= value;
                        break;
                    default:
                        break;
                }

            }

            // Print the resulting jagged matrix
            foreach (double[] row in jagged)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
