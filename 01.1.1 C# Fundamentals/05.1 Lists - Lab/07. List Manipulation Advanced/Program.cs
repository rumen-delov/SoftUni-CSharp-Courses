using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a list of integers
            List<int> intList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            // Mark the list if it is changed (manipulated) 
            bool isChanged = false;

            // Until you receive "end", you will receive different commands
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        intList.Add(numberToAdd);
                        isChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        intList.Remove(numberToRemove);
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        intList.RemoveAt(indexToRemove);
                        isChanged = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        intList.Insert(indexToInsert, numberToInsert);
                        isChanged = true;
                        break;
                    // Extended list of commands
                    case "Contains":
                        int numberToCheck = int.Parse(tokens[1]);
                        if (intList.Contains(numberToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(' ', intList.Where(x => x % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(' ', intList.Where(x => x % 2 == 1)));
                        break;
                    case "GetSum":                       
                        Console.WriteLine(intList.Sum());
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);
                        switch (condition)
                        {
                            case "<":
                                Console.WriteLine(string.Join(' ', intList.Where(x => x < number)));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(' ', intList.Where(x => x > number)));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(' ', intList.Where(x => x <= number)));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(' ', intList.Where(x => x >= number)));
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', intList));
            }
        }
    }
}
