using System;
using System.Collections.Generic;
using System.Text;

namespace Dogs
{
    // To be visible oitside of this project(namespace)
    // use the keyword "public":
    //
    // public class Dog {}

    class Dog 
    {
        // Fields
        private readonly string color;

        
        // Properties with getter and setter
        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }


        // Constructors

        // Default (empty) constructor 
        // Needed for the use of an object initializer
        public Dog()
        {

        }

        // Non-empty constructors  
        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public Dog(string color)
        {
            this.color = color; // Field color is assigned to the parameter color
        }


        // Methods
        public void Bark()
        {
            Console.WriteLine("Bow wow!");
        }

        public void GetColor()
        {
            Console.WriteLine($"The color of this dog is {color}.");
        }
    }
}
 