using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read
            int numberOfDays = int.Parse(Console.ReadLine()); // integer [1...100]
            int playersCount = int.Parse(Console.ReadLine()); // [0...1000]
            double groupEnergy = double.Parse(Console.ReadLine()); // real number [1- 50000]
            double waterDayPerson = double.Parse(Console.ReadLine()); // real number [0.00...1000.00]
            double foodDayPerson = double.Parse(Console.ReadLine()); // real number [0.00...1000.00]

            double waterSupply = waterDayPerson * playersCount * numberOfDays;
            double foodSupply = foodDayPerson * playersCount * numberOfDays;

            bool hasEnergy = true;

            for (int day = 1; day <= numberOfDays; day++)
            {               
                double energyLoss = double.Parse(Console.ReadLine()); // real number [0.00...1000.00]
                
                // 1.Chopping wood
                groupEnergy -= energyLoss;

                if (groupEnergy <= 0)
                {
                    hasEnergy = false;
                    break;
                }

                // 2.Drinking water
                if (day % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    waterSupply -= waterSupply * 0.3;
                }

                // 3.Eating food
                if (day % 3 == 0)
                {
                    groupEnergy += groupEnergy * 0.1;
                    foodSupply -= (foodSupply / playersCount);
                }
            }

            if (!hasEnergy)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodSupply:F2} food and {waterSupply:F2} water.");               
            }
            else 
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }             
        }
    }
}
