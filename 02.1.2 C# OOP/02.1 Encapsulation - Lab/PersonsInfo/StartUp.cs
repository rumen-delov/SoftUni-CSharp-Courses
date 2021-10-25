using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Problem 1: Sort Persons by Name and Age

            //int lines = int.Parse(Console.ReadLine());
            //List<Person> persons = new List<Person>();

            //for (int i = 0; i < lines; i++)
            //{
            //    string[] cmdArgs = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //    Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            //    persons.Add(person);
            //}

            //persons.OrderBy(p => p.FirstName)
            //    .ThenBy(p => p.Age)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.ToString()));



            // Problem 2: Salary Increase
            // and
            // Problem 3: Validation of Data
            //int lines = int.Parse(Console.ReadLine());
            //List<Person> persons = new List<Person>();

            //for (int i = 0; i < lines; i++)
            //{
            //    string[] cmdArgs = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    try
            //    {
            //        Person person = new Person(cmdArgs[0],
            //               cmdArgs[1],
            //               int.Parse(cmdArgs[2]),
            //               decimal.Parse(cmdArgs[3]));

            //        persons.Add(person);
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //decimal bonusPercentage = decimal.Parse(Console.ReadLine());
            //persons.ForEach(p => p.IncreaseSalary(bonusPercentage));
            //persons.ForEach(p => Console.WriteLine(p.ToString()));



            // Problem 4: First and Reserve Team

            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    Person person = new Person(cmdArgs[0],
                           cmdArgs[1],
                           int.Parse(cmdArgs[2]),
                           decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}