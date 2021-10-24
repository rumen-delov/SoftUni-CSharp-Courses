using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Task 1
            //Dog dog = new Dog();
            //dog.Bark();
            //dog.Eat();

            // Task 2
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();


            // Task 3
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

            // My tests
            //Animal animal = new Animal();
            //animal.Name = "Spike";
            //animal.Eat();
            ////dog.Name = "Killer";
            //dog.Identify();
        }
    }
}
