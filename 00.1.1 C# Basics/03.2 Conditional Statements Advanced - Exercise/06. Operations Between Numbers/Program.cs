using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operatorType = Console.ReadLine();

            double result = 0;

            if (operatorType == "+")
            {
                result = N1 + N2;
            }
            else if (operatorType == "-")
            {
                result = N1 - N2;
            }
            else if (operatorType == "*")
            {
                result = N1 * N2;
            }
            else if (operatorType == "/")
            {
                if (N2 != 0)
                {
                    result = (N1 * 1.0) / (N2 * 1.0); // MULTIPLY BY 1.0 TO TURN THE INT INTO DOUBLE
                    Console.WriteLine($"{N1} / {N2} = {result:F2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }
            else if (operatorType == "%")
            {
                if (N2 != 0)
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
            }

            if (operatorType == "+" || operatorType == "-" || operatorType == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {operatorType} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {operatorType} {N2} = {result} - odd");
                }
            } 
        }
    }
}
