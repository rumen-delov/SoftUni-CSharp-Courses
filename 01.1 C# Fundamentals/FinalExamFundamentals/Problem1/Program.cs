using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];

                
                switch (command)
                {
                    case "Change":
                        string symbol = tokens[1];
                        string replacement = tokens[2];

                        text = text.Replace(symbol, replacement);

                        Console.WriteLine(text);
                        break;
                    case "Includes":
                        string includedString = tokens[1];

                        Console.WriteLine(text.Contains(includedString));
                        break;
                    case "End":
                        string endString = tokens[1];

                        int endLength = endString.Length;
                        int textLength = text.Length;
                        
                        string textEnd = text.Substring(textLength - endLength);

                        Console.WriteLine(endString == textEnd);
                        break;
                    case "Uppercase":
                        text = text.ToUpper();

                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        string character = tokens[1];

                        Console.WriteLine(text.IndexOf(character)); 
                        break;
                    case "Cut":
                        int startIndex = int.Parse(tokens[1]);
                        int length = int.Parse(tokens[2]);

                        //text = text.Remove(0, startIndex);
                        //text = text.Remove(length);
                        text = text.Substring(startIndex, length); 

                        Console.WriteLine(text);
                        break;
                    //default:
                    //    break;
                }
            }
        }
    }
}
