using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int durationInDays = int.Parse(Console.ReadLine());
            int pastryChefs = int.Parse(Console.ReadLine());
            int cakesPerChefPerDay = int.Parse(Console.ReadLine());
            int wafflesPerChefPerDay = int.Parse(Console.ReadLine());
            int pancakesPerChefPerDay = int.Parse(Console.ReadLine());

            double cakesSalesPerChefPerDay = cakesPerChefPerDay * 45;
            double wafflesSalesPerChefPerDay = wafflesPerChefPerDay * 5.80;
            double pancakesSalesPerChefPerDay = pancakesPerChefPerDay * 3.20;

            double salesPerDay = pastryChefs * (cakesSalesPerChefPerDay + wafflesSalesPerChefPerDay + pancakesSalesPerChefPerDay);

            double revenue = salesPerDay * durationInDays;
            double productsCost = revenue / 8;

            double donation = revenue - productsCost;

            Console.WriteLine(donation);
        }
    }
}
