using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number, the input unit and the output unit
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            double convertedNumber = 0.0;

            // Conditions
            if (inputUnit == "mm")
            {
                if (outputUnit == "cm")
                {
                    convertedNumber = number * 0.1;
                } 
                else if (outputUnit == "m")
                {
                    convertedNumber = number * 0.001;
                }
            } 
            else if (inputUnit == "cm")
            {
                if (outputUnit == "mm")
                {
                    convertedNumber = number * 10;
                }
                else if (outputUnit == "m")
                {
                    convertedNumber = number * 0.01;
                }
            }
            else if (inputUnit == "m")
            {
                if (outputUnit == "mm")
                {
                    convertedNumber = number * 1000;
                }
                else if (outputUnit == "cm")
                {
                    convertedNumber = number * 100;
                }
            }

            // Write the converted number
            Console.WriteLine($"{convertedNumber:F3}");
        }
    }
}
