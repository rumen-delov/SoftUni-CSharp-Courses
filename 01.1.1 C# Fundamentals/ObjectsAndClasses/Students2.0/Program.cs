using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0
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

                // Check if a student already exists
                // (first name and last name should be unique)

                // Option 1

                //if (IsStudentExisting(students, firstName, lastName))
                //{
                //    // Overwrite the student information

                //    // 1. Find the existing student
                //    Student student = GetStudent(students, firstName, lastName);

                //    // 2. Overwrite the student information
                //    student.FirstName = firstName;
                //    student.LastName = lastName;
                //    student.Age = age;
                //    student.City = city;

                //}
                //else
                //{
                //    Student student = new Student()
                //    {
                //        FirstName = firstName,
                //        LastName = lastName,
                //        Age = age,
                //        City = city
                //    };

                //    students.Add(student);
                //}

                // Option 2
                // Using LINQ Method FirstOrDefault()

                Student student = students
                    .FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                // If there is no existing student with such first and last name,
                if (student == null)
                {
                    
                    // create new student
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    });
                }
                else
                {
                    // otherwise overwrite the existing student
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
            }

            string filterCity = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(s => s.City == filterCity)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

        private static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
