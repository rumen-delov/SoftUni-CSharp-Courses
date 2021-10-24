using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Constructor 1
            RandomList strings = new RandomList();
            strings.Add("one");
            strings.Add("two");
            strings.Add("three");

            string removedString = strings.RandomString();
            Console.WriteLine(removedString);
            Console.WriteLine(string.Join(' ', strings));

            // Constructor 2
            RandomList strings2 = new RandomList { "four", "five", "six" };
            string removedString2 = strings2.RandomString();

            Console.WriteLine(removedString2);
            Console.WriteLine(string.Join(' ', strings2));

            // Constructor 3
            string[] someStrings = new string[] { "seven", "eight", "nine", "ten", "eleven", "twelve" };
            RandomList strings3 = new RandomList(someStrings);

            string removedString3 = strings3.RandomString();
            Console.WriteLine(removedString3);
            Console.WriteLine(string.Join(' ', strings3));
        }
    }
}
