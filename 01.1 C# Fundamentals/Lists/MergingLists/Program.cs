using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receive two lists with numbers
            List<int> numList1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> numList2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            int length = Math.Min(numList1.Count, numList2.Count);

            for (int i = 0; i < length; i++)
            {
                resultList.Add(numList1[i]);
                resultList.Add(numList2[i]);
            }

            if (numList1.Count > numList2.Count)
            {
                // Option 1 with a method definition

                resultList.AddRange(GetRemainingElements(numList1, numList2));

                // Option 2

                //for (int i = numList2.Count; i < numList1.Count; i++)
                //{
                //    resultList.Add(numList1[i]);
                //}
            }
            else if (numList2.Count > numList1.Count)
            {
                // Option 1 with a method definition

                resultList.AddRange(GetRemainingElements(numList2, numList1));

                // Option 2

                //for (int i = numList1.Count; i < numList2.Count; i++)
                //{
                //    resultList.Add(numList2[i]);
                //}
            }

            Console.WriteLine(string.Join(' ', resultList));
        }

        // Option 1
        // Method definition
        static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
            List<int> remainingNumList = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                remainingNumList.Add(longerList[i]);
            }

            return remainingNumList;
        }
    }
}
