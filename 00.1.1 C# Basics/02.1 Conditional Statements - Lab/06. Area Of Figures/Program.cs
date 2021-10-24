using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the geometric shape
            string geometricShape = Console.ReadLine();

            double shapeArea = 0;

            // Condition
            if (geometricShape == "square")
            {
                double sideLength = double.Parse(Console.ReadLine());
                shapeArea = sideLength * sideLength; 

            } else if (geometricShape == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                shapeArea = length * width;
            }
            else if (geometricShape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                shapeArea = radius * radius * Math.PI;
            }
            else if (geometricShape == "triangle")
            {
                double baseSide = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                shapeArea = (baseSide * height)/2;
            }

            // Write the calculated area of the shape used  
            Console.WriteLine($"{shapeArea:F3}");
        }
    }
}
