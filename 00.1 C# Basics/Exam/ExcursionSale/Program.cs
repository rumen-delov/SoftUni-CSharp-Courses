using System;

namespace ExcursionSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSeaExcursions = int.Parse(Console.ReadLine());
            int numberMountainExcursions = int.Parse(Console.ReadLine());

            double profit = 0;

            bool command = true;


            while (command)
            {
                string excursionType = Console.ReadLine();

                if ((numberSeaExcursions + numberMountainExcursions) > 0)
                {
                    if (excursionType == "sea")
                    {
                        if (numberSeaExcursions > 0)
                        {
                            numberSeaExcursions--;
                            profit += 680;
                        }

                    }
                    else if (excursionType == "mountain")
                    {
                        if (numberMountainExcursions > 0)
                        {
                            numberMountainExcursions--;
                            profit += 499;
                        }
                    }
                    else if (excursionType == "Stop")
                    {
                        command = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    command = false;
                    break;
                }


            }

            Console.WriteLine($"Profit: {profit} leva.");

        }
    }
}
