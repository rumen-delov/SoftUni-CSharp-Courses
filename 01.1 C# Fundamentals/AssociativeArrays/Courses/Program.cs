using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentsByCourse = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }


                string[] tokens = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string course = tokens[0];
                string student = tokens[1];

                if (!studentsByCourse.ContainsKey(course))
                {
                    studentsByCourse.Add(course, new List<string>());
                }

                studentsByCourse[course].Add(student);
            }

            Dictionary<string, List<string>> sortedCourses = studentsByCourse
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var dictRecord in sortedCourses)
            {
                Console.WriteLine($"{dictRecord.Key}: {dictRecord.Value.Count}");

                List<string> sortedStudents = dictRecord.Value
                    .OrderBy(s => s)
                    .ToList();
                // or
                //dictRecord.Value.Sort();

                foreach (var student in sortedStudents)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
