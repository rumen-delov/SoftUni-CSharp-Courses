using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Option 1
            // HashSet

            int numberOfUsernames = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < numberOfUsernames; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }

            foreach (string username in usernames)
            {
                Console.WriteLine(username);
            }

            // Option 2
            // Dictionary

            //int numberOfUsernames = int.Parse(Console.ReadLine());
            //Dictionary<string, int> usernames = new Dictionary<string, int>();

            //for (int i = 0; i < numberOfUsernames; i++)
            //{
            //    string username = Console.ReadLine();
            //    int count = 0;

            //    if (usernames.ContainsKey(username))
            //    {
            //        continue;
            //    }
            //    usernames.Add(username, count++);
            //}

            //foreach (var username in usernames)
            //{
            //    Console.WriteLine(username.Key);
            //}
        }
    }
}
