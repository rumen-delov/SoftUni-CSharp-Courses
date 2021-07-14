using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the best DNA sequence to use in the production. 
            // The first line holds the length of the sequences – integer in range [1...100];
            int seqLength = int.Parse(Console.ReadLine());

            // Create an array to store the array with the best DNA sequence
            int[] bestDNASeq = new int[seqLength];

            // Store 
            int bestSubseqSize = 0; // the size of the longest subsquence of ones                        
            int bestSeqStartingIndex = 0; // the starting index of the sample with the longest subsquence of ones
            int bestSeqSum = 0; // the sum of the all ones in the sample with the longest subsquence of ones
            int bestSeqSampleNumber = 1;  // the index number of the sample with the longest subsquence of ones
                                          // in case of no '1's (thus only '0's) we have at least one received sample of this kind
                                          // that is why we set it to 1 (bestSeqSampleNumber = 1)


            // The number of the DNA sample  
            int sampleNumber = 0;

            while (true)
            {
                // On the next lines until you receive "Clone them!" you will be receiving 
                // sequences (at least one) of ones and zeroes, split by "!" (one or several).
                string input = Console.ReadLine();

                // If the input is not the command "Clone them!" then it is a DNA sample
                // so we increase sample number
                sampleNumber++;

                if(input == "Clone them!")
                {
                    break;
                }

                // Allocate an array with the currently received DNA sample               
                int[] currentSample = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                // Count the number of all '1's in the current sample
                int seqSum = 0;
                foreach (var number in currentSample)
                {
                    seqSum += number;
                }

                for (int i = 0; i < currentSample.Length; i++)
                {
                    int currentNumber = currentSample[i];
                    if (currentNumber == 0)
                    {
                        continue;
                    }

                    // Count the '1's in a subsequence starting from the current index of the sample
                    int currentSubseqSize = 1;

                    // Check if there more '1's following this '1' starting from the next index
                    for (int j = i + 1; j < currentSample.Length; j++)
                    {
                        if (currentNumber == currentSample[j])
                        {
                            currentSubseqSize++;                           
                        }
                        else
                        {
                            break;
                        }
                    }

                    int startingIndex = i;

                    // Check for the longest subsequence of '1's in all DNA samples
                    if (currentSubseqSize > bestSubseqSize)
                    {
                        bestSubseqSize = currentSubseqSize;
                        bestSeqSampleNumber = sampleNumber;
                        bestSeqSum = seqSum;
                        bestDNASeq = currentSample;
                        bestSeqStartingIndex = startingIndex;
                    }
                    else if (currentSubseqSize == bestSubseqSize)                       
                    {
                        if (startingIndex < bestSeqStartingIndex)
                        {
                            bestSubseqSize = currentSubseqSize;
                            bestSeqSampleNumber = sampleNumber;
                            bestSeqSum = seqSum;
                            bestDNASeq = currentSample;
                            bestSeqStartingIndex = startingIndex;
                        }
                        else if (startingIndex == bestSeqStartingIndex
                                 && seqSum > bestSeqSum)
                        {
                            bestSubseqSize = currentSubseqSize;
                            bestSeqSampleNumber = sampleNumber;
                            bestSeqSum = seqSum;
                            bestDNASeq = currentSample;
                            bestSeqStartingIndex = startingIndex;
                        }
                    }                 
                }
            }

            Console.WriteLine($"Best DNA sample {bestSeqSampleNumber} with sum: {bestSeqSum}.");
            Console.WriteLine(string.Join(' ', bestDNASeq));
        }
    }
}
