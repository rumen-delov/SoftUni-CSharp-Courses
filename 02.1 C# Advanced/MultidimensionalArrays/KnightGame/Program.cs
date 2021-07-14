using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // The knight moves two squares horizontally, then one square vertically, or
            // one square horizontally then two squares vertically — i.e. in an "L" pattern

            int size = int.Parse(Console.ReadLine()); // 0 < size < 30
            char[,] board = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string rowCells = Console.ReadLine();

                for (int j = 0; j < size; j++)
                {
                    board[i, j] = rowCells[j];
                }
            }

            // Remove a minimum of the knights,
            // so there will be no knights left that can attack another knight (no targets left)

            int removedKnightsCounter = 0;

            // The knight needs at least 3 cells in of the directions in order to move
            // and thus have a target
            if (size < 3)
            {
                Console.WriteLine(removedKnightsCounter);
                return;
            }

            bool existTargets = true;

            while (existTargets)
            {
                int maxTargets = 0;
                int knightRow = -1;
                int knightCol = -1;

                // Find the knight/s with the maximum targets and remove it/them
                // until there are no more knights that have targets
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (board[i, j] == 'K')
                        {
                            int currentKnightTargets = CountKnightTargets(board, i, j);

                            if (currentKnightTargets > maxTargets)
                            {
                                maxTargets = currentKnightTargets;
                                knightRow = i;
                                knightCol = j;
                            }
                        }
                    }
                }

                if (maxTargets > 0)
                {
                    board[knightRow, knightCol] = '0';
                    removedKnightsCounter++;
                }
                else
                {
                    existTargets = false;
                }
            }

            Console.WriteLine(removedKnightsCounter);
        }

        private static int CountKnightTargets(char[,] board, int row, int col)
        {
            int targets = 0;

            // 1 
            if (AreValidCoorinates(row - 1, col - 2, board.GetLength(0), board.GetLength(1)))
            {
                if (board[row - 1, col - 2] == 'K')
                {
                    targets++;
                }
            }

            // 2
            if (AreValidCoorinates(row - 2, col - 1, board.GetLength(0), board.GetLength(1)))
            {
                if (board[row - 2, col - 1] == 'K')
                {
                    targets++;
                }
            }

            // 3
            if (AreValidCoorinates(row - 2, col + 1, board.GetLength(0), board.GetLength(1)))
            {
                if (board[row - 2, col + 1] == 'K')
                {
                    targets++;
                }
            }

            // 4
            if (AreValidCoorinates(row - 1, col + 2, board.GetLength(0), board.GetLength(1)))
            {
                if (board[row - 1, col + 2] == 'K')
                {
                    targets++;
                }
            }

            // 5
            if (AreValidCoorinates(row + 1, col + 2, board.GetLength(0), board.GetLength(1)))
            {
                if (board[row + 1, col + 2] == 'K')
                {
                    targets++;
                }
            }

            // 6
            if (AreValidCoorinates(row + 2, col + 1, board.GetLength(0), board.GetLength(1)))
            {
                if (board[row + 2, col + 1] == 'K')
                {
                    targets++;
                }
            }

            // 7
            if (AreValidCoorinates(row + 2, col - 1, board.GetLength(0), board.GetLength(1)))
            {
                if (board[row + 2, col - 1] == 'K')
                {
                    targets++;
                }
            }

            // 8
            if (AreValidCoorinates(row + 1, col - 2, board.GetLength(0), board.GetLength(1)))
            {
                if (board[row + 1, col - 2] == 'K')
                {
                    targets++;
                }
            }

            return targets;
        }

        private static bool AreValidCoorinates(int rowIndex, int colIndex, int rowSize, int colSize)
        {
            return rowIndex >= 0 && rowIndex < rowSize && colIndex >= 0 && colIndex < colSize; 
        }
    }
}
