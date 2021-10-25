using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            // The ASCII character code is 7 or 8 bit long,
            // so we can use byte as an integer type which is 8 bit long
            byte charIndexStart = byte.Parse(Console.ReadLine());
            byte charIndexEnd = byte.Parse(Console.ReadLine());

            for (byte i = charIndexStart; i <= charIndexEnd; i++)
            {
                Console.Write((char)i + " ");
            }
            
            // New line for readibility
            Console.WriteLine();
        }
    }
}
