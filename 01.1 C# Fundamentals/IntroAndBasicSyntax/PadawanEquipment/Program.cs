using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalLightsaberCost = Math.Ceiling(students * 1.1) * lightsaberPrice;
            double totalRobeCost = students * robePrice;
            double totalBeltCost = (students - (students / 6)) * beltPrice;
            
            double totalEquipmentCost = totalLightsaberCost + totalBeltCost + totalRobeCost;

            if (budget >= totalEquipmentCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalEquipmentCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalEquipmentCost-budget:F2}lv more.");
            }
        }
    }
}
