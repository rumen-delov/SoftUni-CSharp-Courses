using System;

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
            strings.AddRange(someStrings);

            Console.WriteLine(string.Join(' ', strings));
        }
    }
}
