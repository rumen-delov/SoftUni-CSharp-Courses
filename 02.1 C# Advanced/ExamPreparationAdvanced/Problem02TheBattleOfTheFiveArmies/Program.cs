using System;

namespace Problem02TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armorCount = int.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine()); // from 5 up to 20 rows

            char[][] map = new char[numberOfRows][];

            int armyPositionRow = 0;
            int armyPositionCol = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                map[i] = new char[rowData.Length];

                for (int j = 0; j < map[i].Length; j++)
                {
                    map[i][j] = rowData[j];

                    if (rowData[j] == 'A')
                    {
                        armyPositionRow = i;
                        armyPositionCol = j;
                        map[i][j] = '-';
                    }
                }
            }

            while (true)
            {
                string[] commandInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string armyMoveDirection = commandInfo[0];
                int orcsSpawnRow = int.Parse(commandInfo[1]);
                int orcsSpawnCol = int.Parse(commandInfo[2]);

                map[orcsSpawnRow][orcsSpawnCol] = 'O';

                switch (armyMoveDirection)
                {                    
                    case "up":
                        armyPositionRow--;
                        if (armyPositionRow < 0)
                        {
                            armyPositionRow++;
                        }
                        break;                     
                    case "down":
                        armyPositionRow++;
                        if (armyPositionRow >= map.Length)
                        {
                            armyPositionRow--;
                        }
                        break;
                    // left
                    case "left":
                        armyPositionCol--;
                        if (armyPositionCol < 0)
                        {
                            armyPositionCol++;
                        }
                        break;
                    // right
                    case "right":
                        armyPositionCol++;
                        if (armyPositionCol >= map[armyPositionRow].Length)
                        {
                            armyPositionCol--;
                        }
                        break;
                }

                armorCount--;

                if (map[armyPositionRow][armyPositionCol] == 'O')
                {
                    armorCount -= 2;
                }
                else if (map[armyPositionRow][armyPositionCol] == 'M')
                {
                    map[armyPositionRow][armyPositionCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armorCount}");
                    break;
                }

                if (armorCount <= 0)
                {
                    map[armyPositionRow][armyPositionCol] = 'X';
                    Console.WriteLine($"The army was defeated at {armyPositionRow};{armyPositionCol}.");
                    break;
                }
                else
                {
                    map[armyPositionRow][armyPositionCol] = '-';
                }
            }

            foreach (char[] row in map)
            {
                Console.WriteLine(string.Join(string.Empty, row));
            }
        }
    }
}
