using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the city and the sales amount
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 0.05:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales * 0.07:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales * 0.08:F2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 0.12:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 0.055:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales * 0.08:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales * 0.12:F2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 0.145:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine($"{sales * 0.045:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine($"{sales * 0.075:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine($"{sales * 0.10:F2}");
                }
                else if (sales > 10000)
                {
                    Console.WriteLine($"{sales * 0.13:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
