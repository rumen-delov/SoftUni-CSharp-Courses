using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //string id = Console.ReadLine();
            //string birthdate = Console.ReadLine();

            //IPerson person = new Citizen(name, age);

            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);

            //IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            //IBirthable birthable = new Citizen(name, age, id, birthdate);

            //Console.WriteLine(identifiable.Id);
            //Console.WriteLine(birthable.Birthdate);

            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] data = input.Split();

                if (data.Length == 2)
                {
                    identifiables.Add(new Robot(data[0], data[1]));
                }
                else
                {
                    identifiables.Add(new Citizen(data[0], int.Parse(data[1]), data[2]));
                }

            }

            string checkDigits = Console.ReadLine();

            List<IIdentifiable> detained = identifiables
                .Where(i => i.Id.EndsWith(checkDigits))
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, detained.Select(i => i.Id))); 
        }
    }
}
