using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> biscuitsList = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Eat")
                {
                    break;
                }

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string biscuit = tokens[1];

                switch (command)
                {
                    case "Update-Any":
                        for (int i = 0; i < biscuitsList.Count; i++)
                        {
                            if (biscuitsList[i] == biscuit)
                            {
                                biscuitsList[i] = "Out of stock";
                            }
                        }
                        break;
                    case "Remove":
                        int index = int.Parse(tokens[2]);
                        if (index < biscuitsList.Count)
                        {
                            biscuitsList[index] = biscuit;
                        }
                        break;
                    case "Update-Last":
                        int lastElement = biscuitsList.Count - 1;
                        biscuitsList[lastElement] = biscuit;
                        break;
                    case "Rearrange":
                        bool removed = biscuitsList.Remove(biscuit);
                        if (removed)
                        {
                            biscuitsList.Add(biscuit);
                        }
                        break;
                    default:
                        break;
                }
            }

            biscuitsList.RemoveAll(x => x == "Out of stock");
            Console.WriteLine(string.Join(' ', biscuitsList));
        }
    }
}
