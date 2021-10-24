using System;
using System.Collections.Generic;
using System.Linq;

namespace Students1._0
{
    class Program
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string City { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "end")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);
            }

            string filterCity = Console.ReadLine();

            // Option 1

            foreach (Student student in students)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

            // Option 2
            // Using LINQ to filter the students

            //List<Student> filteredStudents = students
            //    .Where(s => s.City == filterCity)
            //    .ToList();

            //foreach (Student student in filteredStudents)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //}
        }
    }
}
