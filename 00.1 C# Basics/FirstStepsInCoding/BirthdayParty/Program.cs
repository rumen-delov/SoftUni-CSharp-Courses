using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double birthdayCakePrice = hallRent * 0.2;
            double beveragesCost = birthdayCakePrice - (birthdayCakePrice * 0.45);
            double entertainerCost = hallRent / 3;

            double totalCost = hallRent + birthdayCakePrice + beveragesCost + entertainerCost; 
            
            Console.WriteLine(totalCost);
        }
    }
}
