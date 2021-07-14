using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Task 1,2
            //Person person1 = new Person();
            //person1.Name = "Peter";
            //person1.Age = 20;

            //Person person2 = new Person
            //{
            //    Name = "George",
            //    Age = 18
            //};

            //Person person3 = new Person
            //{
            //    Name = "Sam",
            //    Age = 43
            //};

            // Task 2
            //Person person4 = new Person();
            //Person person5 = new Person(22);
            //Person person6 = new Person("Leo", 31);

            // Task 1,2
            //Console.WriteLine("Name: \t Age:");
            //Console.WriteLine($"{person1.Name} \t {person1.Age}");
            //Console.WriteLine($"{person2.Name} \t {person2.Age}");
            //Console.WriteLine($"{person3.Name} \t {person3.Age}");
            // Task 2
            //Console.WriteLine($"{person4.Name} \t {person4.Age}");
            //Console.WriteLine($"{person5.Name} \t {person5.Age}");
            //Console.WriteLine($"{person6.Name} \t {person6.Age}");

            // Task 3
            // Number of people as an input
            //int numOfPeople = int.Parse(Console.ReadLine());

            //Family family = new Family();

            //for (int i = 0; i < numOfPeople; i++)
            //{
            //    // Read the name and age of each person
            //    string[] personsData = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //    string name = personsData[0];
            //    int age = int.Parse(personsData[1]);

            //    family.AddMember(new Person(name, age));
            //}

            //Console.WriteLine(family.GetOldestMember());

            // Task 4           
            // Number of people as an input
            int numOfPeople = int.Parse(Console.ReadLine());

            HashSet<Person> people = new HashSet<Person>();

            for (int i = 0; i < numOfPeople; i++)
            {
                // Read the name and age of each person
                string[] personsData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = personsData[0];
                int age = int.Parse(personsData[1]);

                people.Add(new Person(name, age));
            }

            // Print all people, whose age is more than 30 years, sorted in alphabetical order
            HashSet<Person> peopleOver30 = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToHashSet();

            Console.WriteLine(string.Join(Environment.NewLine, peopleOver30));
        }
    }
}
