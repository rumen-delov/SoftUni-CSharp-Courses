using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Beast!")
                {
                    break;
                }

                string animalType = input;

                string[] animalInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string animalName = animalInfo[0];
                int animalAge = int.Parse(animalInfo[1]);
                string animalGender = animalInfo[2];

                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            animals.Add(new Dog(animalName, animalAge, animalGender));
                            break;
                        case "Cat":
                            animals.Add(new Cat(animalName, animalAge, animalGender));
                            break;
                        case "Frog":
                            animals.Add(new Frog(animalName, animalAge, animalGender));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(animalName, animalAge));
                            break;
                        case "Tomcat":
                            animals.Add(new Tomcat(animalName, animalAge));
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Print all the animals
            animals.ForEach(Console.WriteLine);
        }
    }
}
