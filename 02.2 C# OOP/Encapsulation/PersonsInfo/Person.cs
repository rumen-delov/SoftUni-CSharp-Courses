﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

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

        // Problem 1,2,3 
        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }

        // Problem 2
        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }

                this.salary = value;
            }
        }

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
        //public override string ToString()
        //{
        //    return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        //}

        // Problem 3
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} gets {this.Salary:F2} leva.";
        }
    }
}
