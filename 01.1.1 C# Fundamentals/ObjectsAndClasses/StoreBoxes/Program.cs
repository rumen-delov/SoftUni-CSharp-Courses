using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        public class Item
        {
            public string Name { get; set; }

            public decimal Price { get; set; }
        }

        public class Box
        {
            // Option 1.1
            // Create an instance of Item in the Box constructor
            public Box()
            {
                Item = new Item();
            }
            
            public string SerialNumber { get; set; }

            public Item Item { get; set; }

            public int Quantity { get; set; }

            public decimal PriceBox { get; set; }
        }

        static void Main(string[] args)
        {

            List<Box> boxes = new List<Box>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Box box = new Box();

                // Option 1.2

                box.Item.Name = itemName;
                box.Item.Price = itemPrice;

                // Option 2
                // After you create a new instance of Box
                // Access the Item property and create a new instance

                //box.Item = new Item()
                //{
                //    Name = itemName,
                //    Price = itemPrice
                //};
                box.SerialNumber = serialNumber;
                box.Quantity = itemQuantity;
                box.PriceBox = itemQuantity * itemPrice;

                boxes.Add(box);
            }

            List<Box> orderedByPrice = boxes
                .OrderByDescending(b => b.PriceBox)
                .ToList();

            foreach (Box box in orderedByPrice)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }
}