using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // The number of lines to be read should be in the range from 1 to 20
            // so integer type byte can be used which is in the range from 0 to 255  
            byte linesToRead = byte.Parse(Console.ReadLine());

            // The sum of the ASCII numbers corresponding to given characters can fit
            // in the ushort type range which is from 0 to 65535
            ushort charSum = 0; 

            for (byte line = 1; line <= linesToRead; line++)
            {
                char latinLetter = char.Parse(Console.ReadLine());
                charSum += latinLetter;
            }
            
            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}
