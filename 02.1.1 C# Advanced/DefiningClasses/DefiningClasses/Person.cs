using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        // Task 1
        private string name;
        private int age;

        // Task 2
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) 
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }

        // Task 1
        public string Name 
        { 
            get => this.name;
            set => this.name = value; 
        }

        public int Age 
        { 
            get => this.age; 
            set => this.age = value; 
        }

        // Task 3
        //public override string ToString()
        //{
        //    return $"{this.Name} {this.Age}";
        //}

        // Task 4
        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
