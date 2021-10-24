using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCarsToPass = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            int totalCarsPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToUpper() == "END")
                {
                    break;
                }
                
                if (input.ToUpper() == "GREEN")
                {
                    for (int i = 0; i < numberCarsToPass; i++)
                    {
                        if (carsQueue.Count > 0)
                        {
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                            totalCarsPassed++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
            }

            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}