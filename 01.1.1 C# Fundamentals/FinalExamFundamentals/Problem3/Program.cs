using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> emailManager = new Dictionary<string, List<string>>();
            
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] tokens = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        string usernameToAdd = tokens[1];

                        if (emailManager.ContainsKey(usernameToAdd))
                        {
                            Console.WriteLine($"{usernameToAdd} is already registered");
                        }
                        else
                        {
                            emailManager.Add(usernameToAdd, new List<string>());
                        }

                        break;

                    case "Send":
                        string usernameOfSender = tokens[1];
                        string emailToSend = tokens[2];

                        emailManager[usernameOfSender].Add(emailToSend);

                        break;

                    case "Delete":
                        string usernameToDelete = tokens[1];

                        if (emailManager.ContainsKey(usernameToDelete))
                        {
                            emailManager.Remove(usernameToDelete);
                        }
                        else
                        {
                            Console.WriteLine($"{usernameToDelete} not found!");
                        }

                        break;

                    default:
                        break;
                }

            }

            Dictionary<string, List<string>> sorted = emailManager
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);


            Console.WriteLine($"Users count: {sorted.Count}");

            foreach (var dictRecord in sorted)
            {
                Console.WriteLine($"{dictRecord.Key}");

                foreach (var email in dictRecord.Value)
                {
                    Console.WriteLine($" - {email}");
                }
            }

        }
    }
}
