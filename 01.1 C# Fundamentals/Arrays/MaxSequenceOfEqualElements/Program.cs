using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the longest sequence of equal elements in an array of integers.
            // If several longest sequences exist, print the leftmost one.

            int[] intArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxSeq = 1;
            int maxSeqNum = intArr[0];
            int i = 0;

            while (i < intArr.Length)
            {
                int seqCounter = 1;
                int currentNumber = intArr[i];
                
                for (int j = i + 1; j < intArr.Length; j++)
                {
                    
                    int rightNumber = intArr[j];
                    
                    if (currentNumber != rightNumber)
                    {
                        break;
                    }

                    seqCounter++;
                }

                if (seqCounter > maxSeq)
                {
                    maxSeq = seqCounter;
                    maxSeqNum = currentNumber;
                }

                i += seqCounter; 
            }

            for (int k = 0; k < maxSeq; k++)
            {
                Console.Write($"{maxSeqNum} ");
            }
        }
    }
}
