using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an array of strings (space separated values) 
            string[] stringsArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Reverse it and print the elements

            // Option 1 
            Console.WriteLine(string.Join(' ', stringsArray.Reverse()));
            // stringsArray.Reverse() reverses the array but it creates a temporary array
            // after it is used stringsArray is still with the original order of the elements

            // Option 2
            //for (int i = 0; i < stringsArray.Length / 2; i++)
            //{
            //    string swapValue = stringsArray[i];
            //    stringsArray[i] = stringsArray[stringsArray.Length - 1 - i];
            //    stringsArray[stringsArray.Length - 1 - i] = swapValue;
            //}

            //for (int i = 0; i < stringsArray.Length; i++)
            //{
            //    Console.Write(stringsArray[i] + " ");
            //}

            // Option 3
            //Array.Reverse(stringsArray);

            //Console.WriteLine(string.Join(' ', stringsArray));
        }
    }
}
