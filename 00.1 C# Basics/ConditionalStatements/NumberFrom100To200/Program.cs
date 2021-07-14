using System;

namespace NumberFrom100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number
            int number = int.Parse(Console.ReadLine());

            // Condition
            if (number < 100) 
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >= 100 && number <= 200) 
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
