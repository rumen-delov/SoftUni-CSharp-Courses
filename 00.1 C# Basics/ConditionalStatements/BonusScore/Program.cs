using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number
            int number = int.Parse(Console.ReadLine());

            // Declare the bonus as a global variable
            double bonus = 0.0;

            if (number <= 100) 
            {
                bonus = 5;
            } else if (number > 100 && number <= 1000)
            {
                bonus = number * 0.2;
            } else if (number > 1000)
            {
                bonus = number * 0.1;
            }

            if (number % 2 == 0)
            {
                bonus += 1;
            } else if ((number % 5 == 0) && (number % 2 != 0))
            {
                bonus += 2;
            }
            
            // Write the results
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
