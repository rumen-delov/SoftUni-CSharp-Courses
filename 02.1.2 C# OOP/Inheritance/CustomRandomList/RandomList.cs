using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;

        public RandomList() 
        {
        }

        public RandomList(IEnumerable<string> collection)
            : base(collection)
        {
        }

        public RandomList(int capacity)
            : base(capacity)
        {
        }

        public string RandomString()
        {
            rnd = new Random();
            int index = rnd.Next(0, this.Count);

            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
