using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // number of people in a group, type of the group and day of the week as an input
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();

            double totalPrice = 0;
            double discount = 0;

            // Students
            if (groupType == "Students")
            {              
                if (weekDay == "Friday")
                {
                    totalPrice = groupSize * 8.45;
                }
                else if (weekDay == "Saturday")
                {
                    totalPrice = groupSize * 9.80;
                }
                // else
                else if (weekDay == "Sunday")
                {
                    totalPrice = groupSize * 10.46;
                }

                if (groupSize >= 30)
                {
                    discount = 0.15; // 15% discount
                    totalPrice -= totalPrice * discount;
                }
            }
            // Business
            else if (groupType == "Business")
            {
                if (groupSize >= 100)
                {
                    groupSize -= 10; 
                }
                
                if (weekDay == "Friday")
                {
                    totalPrice = groupSize * 10.90;
                }
                else if (weekDay == "Saturday")
                {
                    totalPrice = groupSize * 15.60;
                }
                // else
                else if (weekDay == "Sunday")
                {
                    totalPrice = groupSize * 16.00;
                }
            }
            // Regular
            else if (groupType == "Regular")
            {   
                if (weekDay == "Friday")
                {
                    totalPrice = groupSize * 15.00;
                }
                else if (weekDay == "Saturday")
                {
                    totalPrice = groupSize * 20.00;
                }
                // else
                else if (weekDay == "Sunday")
                {
                    totalPrice = groupSize * 22.50;
                }

                                if (groupSize >= 10 && groupSize<= 20)
                {
                    discount = 0.05; // 5% discount
                    totalPrice -= totalPrice * discount;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");

            }
    }
}
