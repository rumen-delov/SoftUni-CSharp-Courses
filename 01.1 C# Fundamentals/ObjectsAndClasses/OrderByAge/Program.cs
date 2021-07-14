using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }

            public string ID { get; set; }

            public int Age { get; set; }
        }
        
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();       
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person
                {
                    Name = name,
                    ID = id,
                    Age = age
                };

                persons.Add(person);
            }

            // Print all the people, ordered by age
            List<Person> orderedByAge = persons
                .OrderBy(p => p.Age)
                .ToList();

            foreach (Person person in orderedByAge)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}