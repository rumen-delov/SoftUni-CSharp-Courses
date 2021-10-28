using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings strings = new StackOfStrings();
            strings.Push("A");
            strings.Push("B");
            strings.Push("C");

            string[] someStrings = new string[] { "D", "E", "F" };

            //strings.AddRange(someStrings);
            //StackOfStrings newStrings = strings.AddRange(someStrings);
            Stack<string> newStrings = strings.AddRange(someStrings);

            Console.WriteLine(string.Join(' ', strings));
            Console.WriteLine(string.Join(' ', newStrings));

            List<string> someOtherStrings = new List<string> { "G", "H" };
            strings.AddRange(someOtherStrings);

            Console.WriteLine(string.Join(' ', strings));
        }
    }
}
