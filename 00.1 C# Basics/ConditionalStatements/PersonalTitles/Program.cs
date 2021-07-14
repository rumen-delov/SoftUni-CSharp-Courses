using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the age and gender
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            // Condition for the gender
            if (gender == "f")
            {
                // Condition for the age if the person is female
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                // Condition for the age if the person is male
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}
