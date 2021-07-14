using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            // The first line of the input will be your raw activation key.
            // It will consist of letters and numbers only.
            string rawActivationKey = Console.ReadLine();

            // Until the "Generate" command is given, you will be receiving strings with instructions for 
            // different operations that need to be performed upon the raw activation key.
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Generate")
                {
                    break;
                }

                string[] tokens = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string instruction = tokens[0];

                switch (instruction)
                {
                    case "Contains":
                        string substring = tokens[1];

                        // Check if the raw activation key contains the given substring
                        if (rawActivationKey.Contains(substring))
                        {
                            Console.WriteLine($"{rawActivationKey} contains {substring}"); 
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }

                        break;
                    case "Flip":
                        string caseMode = tokens[1]; // could be "Upper" or "Lower"
                        int flipStartIndex = int.Parse(tokens[2]);
                        int flipEndIndex = int.Parse(tokens[3]);

                        // Change the substring between the given indices to upper or lower case.
                        // The end index is exclusive (not included). All given indexes will be valid.
                        string substringToFlip = rawActivationKey.Substring(flipStartIndex, flipEndIndex - flipStartIndex);
                        string replacement = caseMode == "Upper" 
                            ? substringToFlip.ToUpper() 
                            : substringToFlip.ToLower();

                        rawActivationKey = rawActivationKey.Replace(substringToFlip, replacement);

                        // Print the activation key
                        Console.WriteLine(rawActivationKey);
                        break;
                    case "Slice":
                        // Delete the characters between the start and end indices (end index is exclusive).
                        // Both indices will be valid.
                        int sliceStartIndex = int.Parse(tokens[1]);
                        int sliceEndIndex = int.Parse(tokens[2]);
                        rawActivationKey = rawActivationKey.Remove(sliceStartIndex, sliceEndIndex - sliceStartIndex);

                        // Print the activation key
                        Console.WriteLine(rawActivationKey);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }        
    }
}
