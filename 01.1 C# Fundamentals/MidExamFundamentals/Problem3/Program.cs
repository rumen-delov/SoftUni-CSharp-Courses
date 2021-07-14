using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> booksShelf = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                string[] tokens = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "Add Book":
                        string bookToAdd = tokens[1];
                        if (booksShelf.Contains(bookToAdd))
                        {
                            continue;
                        }
                        else
                        {
                            booksShelf.Insert(0, bookToAdd);
                        }
                        break;
                    case "Take Book":
                        string bookToRemove = tokens[1];
                        if (booksShelf.Contains(bookToRemove))
                        {
                            booksShelf.Remove(bookToRemove);
                        }
                        else
                        {                            
                            continue;
                        }
                        break;
                    case "Swap Books":
                        string bookToSwap1 = tokens[1];
                        string bookToSwap2 = tokens[2];
                        if (booksShelf.Contains(bookToSwap1) && booksShelf.Contains(bookToSwap2))
                        {
                            int book1Index = booksShelf.IndexOf(bookToSwap1);
                            int book2Index = booksShelf.IndexOf(bookToSwap2);
                            booksShelf[book1Index] = bookToSwap2;
                            booksShelf[book2Index] = bookToSwap1;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Insert Book":
                        string bookToInsert = tokens[1];
                        booksShelf.Add(bookToInsert);
                        break;
                    case "Check Book":
                        int bookIndex = int.Parse(tokens[1]);
                        if (bookIndex >= booksShelf.Count)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(booksShelf[bookIndex]);
                        }
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine(string.Join(", ", booksShelf));
        }
    }
}
