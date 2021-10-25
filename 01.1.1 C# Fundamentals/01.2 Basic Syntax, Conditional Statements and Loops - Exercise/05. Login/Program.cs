using System;
//using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            // username as an input
            string username = Console.ReadLine();

            string password = "";
            // The password is the given username in reverse.
            // There are different options to get the password from the username
            
            // Option 1 
            //string password = string.Concat(username.Reverse()); // "Reverse()" needs "using System.Linq;"
            
            // Option 2
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
         
            // mark if the user is logged in
            bool isLoggedIn = false;
            // mark if the user is blocked
            bool isBlocked = false; 

            // count the number of log in tries
            int logInAttemptsCounter = 0;

            while (!isLoggedIn && !isBlocked)
            {
                // get the password typed by the user
                string attemptedPassword = Console.ReadLine();

                if (attemptedPassword == password)
                {
                    isLoggedIn = true;
                    Console.WriteLine($"User {username} logged in.");
                }
                else
                {
                    logInAttemptsCounter++; // 

                    if (logInAttemptsCounter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        isBlocked = true;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                    }                    
                                                          
                }
            }

        }
    }
}
