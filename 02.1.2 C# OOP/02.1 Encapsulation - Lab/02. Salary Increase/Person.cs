using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        // Problem 1
        //public Person(string firstName, string lastName, int age)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.Age = age;
        //}

        // Problem 2
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        // Problem 1 
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        // Problem 2
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage /= 2;
            }

            this.Salary += percentage / 100 * this.Salary;
        }

        // Problem 1
        //public override string ToString()
        //{
        //    return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        //}

        // Problem 2
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }
    }
}
