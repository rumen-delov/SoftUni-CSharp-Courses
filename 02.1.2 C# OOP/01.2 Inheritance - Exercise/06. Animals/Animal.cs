﻿using System;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;
        
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        {
            get => this.name;

            set
            {
                if (String.IsNullOrWhiteSpace(value)) // String.IsNullOrWhiteSpace(value) includes String.IsNullOrEmpty(value) 
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            } 
        }

        public int Age 
        {
            get => this.age;
                       
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;  
            }
        }

        public string Gender 
        { 
            get => this.gender;
            
            set   
            {
                if (String.IsNullOrWhiteSpace(value) || (value != "Male" && value != "Female"))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append($"{this.ProduceSound()}");          

            return sb.ToString().TrimEnd();
        }
    }
}
