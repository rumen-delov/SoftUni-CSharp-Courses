using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                if (command == "register")
                {
                    string username = tokens[1];
                    string licensePlateNumber = tokens[2];

                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        users.Add(username, licensePlateNumber);

                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else
                {
                    string username = tokens[1];

                    bool removed = users.Remove(username);

                    if (removed)
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }    
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
