using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // We need to read an integer which represents 
            // the number of the first small Latin letters
            // that have to be usedlater in the assignment.
            // The Latin alphabet consists of 26 letters
            // so we can use the integer type byte with range [0...255]
            byte numberOfLetters = byte.Parse(Console.ReadLine());

            // Option 1

            //byte startASCIISmallLetters = 97;

            //for (byte i = startASCIISmallLetters; i < startASCIISmallLetters + numberOfLetters; i++)
            //{
            //    for (byte j = startASCIISmallLetters; j < startASCIISmallLetters + numberOfLetters; j++)
            //    {
            //        for (byte k = startASCIISmallLetters; k < startASCIISmallLetters + numberOfLetters; k++)
            //        {
            //            Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
            //        }
            //    }
            //}

            // Option 2

            for (char i = 'a'; i < 'a' + numberOfLetters; i++)
            {
                for (char j = 'a'; j < 'a' + numberOfLetters; j++)
                {
                    for (char k = 'a'; k < 'a' + numberOfLetters; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
