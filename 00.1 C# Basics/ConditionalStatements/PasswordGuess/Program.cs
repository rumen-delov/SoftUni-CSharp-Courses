using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the password
            string password = Console.ReadLine();

            // Condition
            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            } else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
