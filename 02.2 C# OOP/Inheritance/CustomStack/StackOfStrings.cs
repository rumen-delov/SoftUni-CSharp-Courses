using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public StackOfStrings()
        {
        }

        public StackOfStrings(IEnumerable<string> collection) 
            : base(collection)
        {
        }

        public StackOfStrings(int capacity)
            : base(capacity)
        {
        }

        public bool IsEmpty()
        {
            return this.Count == 0; // or return this.Any();
        }

        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var element in collection)
            {
                this.Push(element);
            }
        }
    }
}
