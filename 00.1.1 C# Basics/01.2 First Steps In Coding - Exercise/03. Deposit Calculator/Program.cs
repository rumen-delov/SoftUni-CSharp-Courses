using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double annualRate = double.Parse(Console.ReadLine());

            double annual_interest = deposit * annualRate / 100;
            double monthly_interest = annual_interest / 12;

            Console.WriteLine(deposit + period * monthly_interest);
        }
    }
}
