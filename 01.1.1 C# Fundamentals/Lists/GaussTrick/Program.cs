using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int originalLength = numList.Count;

            for (int i = 0; i < originalLength/2; i++)
            {
                numList[i] += numList[numList.Count - 1];
                numList.RemoveAt(numList.Count - 1);
            }
            
            Console.WriteLine(string.Join(' ', numList));
        }
    }
}