using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read two arrays of strings
            string[] strArr1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] strArr2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Compare the elements of the second array to the elements of the first
            for (int i = 0; i < strArr2.Length; i++)
            {
                for (int j = 0; j < strArr1.Length; j++)
                {
                    if (strArr2[i].Equals(strArr1[j]))
                    {
                        // Print common elements in two arrays
                        Console.Write(strArr2[i] + " ");
                    }
                }       
            }
        }
    }
}
