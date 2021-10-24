using System;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Reading a string from the console
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string reversedInput = string.Empty;

                for (int i = input.Length -1; i >= 0; i--)
                {
                    // Option 1
                    //reversedInput += input[i];

                    // Option 2
                    reversedInput = string.Concat(reversedInput, input[i]);
                }

                Console.WriteLine($"{input} = {reversedInput}");
            }
        }
    }
}
