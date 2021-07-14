using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = ReadStringArrayFromConsole();
            Queue<string> songsQueue = new Queue<string>(songs);

            while (songsQueue.Count > 0)
            {
                string input = Console.ReadLine();
                string command = string.Empty;
                int separatorIndex = input.IndexOf(' ');
                string song = string.Empty;

                if (separatorIndex > 0)
                {
                    command = input.Substring(0, separatorIndex);
                    song = input.Substring(separatorIndex + 1);
                }
                else
                {
                    command = input;
                }

                switch (command)
                {
                    case "Play":
                        songsQueue.Dequeue();
                        break;
                    case "Add":
                        if (songsQueue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songsQueue));
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("No more songs!");
        }

        private static string[] ReadStringArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
