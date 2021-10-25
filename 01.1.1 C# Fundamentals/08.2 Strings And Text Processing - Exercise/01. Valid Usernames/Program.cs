using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read user names on a single line (joined by ", ") 
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            // Print all valid usernames
            foreach (var username in usernames)
            {
                // A valid username is:
                // - Has length between 3 and 16 characters
                // - Contains only letters, numbers, hyphens and underscores

                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        if (!char.IsDigit(username[i]) && 
                            !char.IsLetter(username[i]) &&
                            username[i] != '-' &&
                            username[i] != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
