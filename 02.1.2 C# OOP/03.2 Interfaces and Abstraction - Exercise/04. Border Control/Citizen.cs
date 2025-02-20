﻿namespace PersonInfo
{
    public class Citizen : IPerson, IBirthable
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
        public Citizen(string name, int age, string id, string birthdate) 
            : this(name, age, id)
        {
            this.Birthdate = birthdate;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthdate { get; private set; }
    }
}
