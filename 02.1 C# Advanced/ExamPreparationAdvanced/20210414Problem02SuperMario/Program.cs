using System;
using System.Linq;

namespace _20210414Problem02SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLives = int.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine()); // from 5 up to 20 rows

            char[][] maze = new char[numberOfRows][];

            int MarioPositionRow = 0;
            int MarioPositionCol = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                maze[i] = new char[rowData.Length];

                for (int j = 0; j < maze[i].Length; j++)
                {
                    maze[i][j] = rowData[j];

                    if (rowData[j] == 'M')
                    {
                        MarioPositionRow = i;
                        MarioPositionCol = j;
                        maze[i][j] = '-';
                    }

                }
            }

            while (true)
            {
                string[] commandInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                char MarioDirection = char.Parse(commandInfo[0]);
                int BowserSpawnRow = int.Parse(commandInfo[1]);
                int BowserSpawnCol = int.Parse(commandInfo[2]);

                maze[BowserSpawnRow][BowserSpawnCol] = 'B';

                switch (MarioDirection)
                {
                    // up
                    case 'W':
                        MarioPositionRow--;
                        if (MarioPositionRow < 0)
                        {
                            MarioPositionRow++;
                        }
                        break;
                    // down
                    case 'S':
                        MarioPositionRow++;
                        if (MarioPositionRow >= maze.Length)
                        {
                            MarioPositionRow--;
                        }
                        break;
                    // left
                    case 'A':
                        MarioPositionCol--;
                        if (MarioPositionCol < 0)
                        {
                            MarioPositionCol++;
                        }
                        break;
                    // right
                    case 'D':
                        MarioPositionCol++;
                        if (MarioPositionCol >= maze[MarioPositionRow].Length)
                        {
                            MarioPositionCol--;
                        }
                        break;
                }

                numberOfLives--;

                if (maze[MarioPositionRow][MarioPositionCol] == 'B')
                {
                    numberOfLives -= 2;
                }
                else if (maze[MarioPositionRow][MarioPositionCol] == 'P')
                {
                    maze[MarioPositionRow][MarioPositionCol] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {numberOfLives}");
                    break;
                }

                if (numberOfLives <= 0)
                {
                    maze[MarioPositionRow][MarioPositionCol] = 'X';
                    Console.WriteLine($"Mario died at {MarioPositionRow};{MarioPositionCol}.");
                    break;
                }
                else
                {
                    maze[MarioPositionRow][MarioPositionCol] = '-';
                }
            }

            foreach (char[] row in maze)
            {
                Console.WriteLine(string.Join(string.Empty, row));
            }
        }
    }
}
