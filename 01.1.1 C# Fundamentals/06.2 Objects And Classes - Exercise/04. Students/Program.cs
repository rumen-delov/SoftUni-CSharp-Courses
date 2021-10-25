using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:F2}";
            }
        }
        static void Main(string[] args)
        {            
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student
                {
                    FirstName = studentData[0],
                    LastName = studentData[1],
                    Grade = double.Parse(studentData[2])
                };

                students.Add(student);
            }

            List<Student> sortedStudents = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}