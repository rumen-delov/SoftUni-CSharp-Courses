using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the finish times of the three racers
            int racer1FinishTime = int.Parse(Console.ReadLine());
            int racer2FinishTime = int.Parse(Console.ReadLine());
            int racer3FinishTime = int.Parse(Console.ReadLine());

            int totalTime = racer1FinishTime + racer2FinishTime + racer3FinishTime;

            // Converting the total time in minutes and seconds
            int minutes = totalTime/60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            } else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }           
        }
    }
}
