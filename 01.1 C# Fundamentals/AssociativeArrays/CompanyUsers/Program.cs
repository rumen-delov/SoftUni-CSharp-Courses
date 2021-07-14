using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = tokens[0];
                string employeeId = tokens[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                companies[company].Add(employeeId);
            }


            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);

                List<string> uniqueEmployees = company.Value
                    .Distinct()
                    .ToList();

                foreach (var employee in uniqueEmployees)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
