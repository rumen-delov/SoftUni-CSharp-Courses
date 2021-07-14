using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int pets = int.Parse(Console.ReadLine());

            Console.WriteLine($"{dogs * 2.50 + pets * 4} lv.");
        }
    }
}
