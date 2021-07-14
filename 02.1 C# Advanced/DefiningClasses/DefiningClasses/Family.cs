using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        // If you want no two members with the same name and age 
        private readonly HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }
        
        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(m => m.Age).FirstOrDefault(); 
        }
    }
}
