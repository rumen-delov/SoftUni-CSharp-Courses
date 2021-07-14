using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the grade
            double grade = double.Parse(Console.ReadLine());

            // Condition
            if (grade >= 5.5)
                Console.WriteLine("Excellent!");
        }
    }
}
