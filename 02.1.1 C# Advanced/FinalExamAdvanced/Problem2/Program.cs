using System;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());
            char[][] beachArea = new char[rowSize][];

            for (int i = 0; i < rowSize; i++)
            {
                beachArea[i] = GetTokensPositionsFromConsole();
            }

            int myCollectedTokens = 0;
            int opponentsCollectedTokens = 0;
            const int NUMBER_OF_STEPS = 3;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Gong")
                {
                    break;
                }

                string[] commandData = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = commandData[0];

                int row = int.Parse(commandData[1]);
                int col = int.Parse(commandData[2]);

                switch (command)
                {
                    case "Find":
                        if (tokenIsCollected(beachArea, row, col))
                        {
                            myCollectedTokens++;
                        }
                        break;
                    case "Opponent":
                        string direction = commandData[3];

                        if (tokenIsCollected(beachArea, row, col))
                        {
                            opponentsCollectedTokens++;

                            for (int i = 0; i < NUMBER_OF_STEPS; i++)
                            {
                                switch (direction)
                                {
                                    case "up":
                                        row--; 
                                        break;
                                    case "down":    
                                        row++; 
                                        break;
                                    case "left":
                                        col--; 
                                        break;
                                    case "right":
                                        col++; 
                                        break;
                                    default:
                                        break;
                                }

                                if (tokenIsCollected(beachArea, row, col))
                                {
                                    opponentsCollectedTokens++;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }

            }

            // Print the last condition of the beach.
            // The cells, containing a token or not, should be separated by single space
            foreach (var row in beachArea)
            {
                Console.WriteLine(string.Join(' ', row));
            }

            // Print the count of the tokens you've collected:
            Console.WriteLine($"Collected tokens: {myCollectedTokens}");

            // Print the number of found by your opponent tokens:
            Console.WriteLine($"Opponent's tokens: {opponentsCollectedTokens}");
        }

        private static bool tokenIsCollected(char[][] jagged, int row, int col)
        {
            if (coordinatesAreValid(jagged, row, col))
            {
                if (jagged[row][col] == 'T')
                {
                    jagged[row][col] = '-';
                    return true;
                }
            }

            return false;
        }

        private static bool coordinatesAreValid(char[][] jagged, int row, int col)
        {
            return row >= 0 &&
                   row < jagged.Length &&
                   col >= 0 &&
                   col < jagged[row].Length;
        }

        private static char[] GetTokensPositionsFromConsole()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
        }
    }
}
