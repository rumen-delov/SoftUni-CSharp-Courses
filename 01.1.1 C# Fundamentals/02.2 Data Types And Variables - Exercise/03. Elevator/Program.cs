using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int personsCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int elevatorCourses = 0;

            // Option 1
            //if (personsCount % elevatorCapacity == 0)
            //{
            //    elevatorCourses = personsCount / elevatorCapacity;
            //}
            //else
            //{
            //    elevatorCourses = (personsCount / elevatorCapacity) + 1;
            //}

            // Option 2
            elevatorCourses = (int)Math.Ceiling((double)personsCount / elevatorCapacity);
            // or by multiplying with 1.0
            //elevatorCourses = (int)Math.Ceiling(personsCount * 1.0 / elevatorCapacity);

            // Option 3
            //for (int i = 0; i < personsCount; i += elevatorCapacity)
            //{
            //    elevatorCourses++;
            //}

            Console.WriteLine(elevatorCourses);
        }
    }
}
