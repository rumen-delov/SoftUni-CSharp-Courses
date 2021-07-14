using System;

namespace Dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Option 1
            Dog rufus = new Dog();
            rufus.Name = "Rufus";
            rufus.Breed = "Shepherd";
            rufus.Age = 3;


            // Option 2
            // Using object initializer
            Dog sparky = new Dog()
            {
                // Use Ctrl + space to display the uninitialized properties
                Name = "Sparky",
                Breed = "Corgi",
                Age = 5
            };


            // Anonymous type objects

            //var rufus = new
            //{
            //    Age = 3, // type is int
            //    Breed = "Shepherd",
            //    Name = "Rufus" 
            //};

            //var rio = new 
            //{
            //    Name = "Rio",
            //    Breed = "Boxer"
            //    Age = 5.32 // now the type is double
            //};


            // Option 3
            // Using constructor
            Dog allie = new Dog("Allie", "Husky", 2);            

            Console.WriteLine($"{rufus.Name} is a {rufus.Breed} and it is {rufus.Age} years old.");
            Console.WriteLine($"{sparky.Name} is a {sparky.Breed} and it is {sparky.Age} years old.");
            Console.WriteLine($"{allie.Name} is a {allie.Breed} and it is {allie.Age} years old.");

            rufus.Bark();
            sparky.Bark();
            allie.Bark();

            // Using another constructor which sets the color
            Dog rio = new Dog("brown");

            rio.GetColor();
        }
    }
}
  