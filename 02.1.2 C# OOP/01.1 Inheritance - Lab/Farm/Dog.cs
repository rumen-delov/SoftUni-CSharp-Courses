using System;

namespace Farm
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }

        // My tests
        //public void Identify()
        //{
        //    Console.WriteLine($"I am a dog named {base.Name}.");
        //}
    }
}
