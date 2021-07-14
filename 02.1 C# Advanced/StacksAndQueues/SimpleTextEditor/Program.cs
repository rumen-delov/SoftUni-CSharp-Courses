using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> results = new Stack<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                int command = int.Parse(input.Substring(0,1));

                switch (command)
                {
                    // append some text
                    case 1:
                        results.Push(text);
                        string textToAppend = input.Substring(2);
                        text = text + textToAppend;
                        //Console.WriteLine(text);
                        break;
                    // erase last count of elements
                    case 2:
                        results.Push(text);
                        int numberOfElements = int.Parse(input.Substring(2));
                        text = text.Remove(text.Length - numberOfElements, numberOfElements);
                        //Console.WriteLine(text);                        
                        break;
                    // return the element at index
                    case 3:
                        int index = int.Parse(input.Substring(2));
                        Console.WriteLine(text[index - 1]);
                        break;
                    // undo the last not undone command of type 1 or 2
                    case 4: 
                        text = results.Pop();
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
