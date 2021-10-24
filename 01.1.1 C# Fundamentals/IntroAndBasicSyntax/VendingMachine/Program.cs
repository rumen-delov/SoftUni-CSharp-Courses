using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // The customer inserts coins until he pushes "Start"
            // while his balance gets updated 

            string input = Console.ReadLine();
            double balance = 0;

            while (input != "Start")
            {
                double currentCoin = double.Parse(input);

                if (currentCoin == 0.1 ||
                    currentCoin == 0.2 ||
                    currentCoin == 0.5 ||
                    currentCoin == 1 ||
                    currentCoin == 2)
                {
                    balance += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }
                
                input = Console.ReadLine();
            }

            // The customer has pushed "Start" on the vending machine
            // and now can do the order
            
            input = Console.ReadLine();

            while (input != "End")
            {
                double productPrice = 0;
                  
                if (input == "Nuts")
                {
                    productPrice = 2;
                }
                else if (input == "Water")
                {
                    productPrice = 0.7;
                }
                else if (input == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (input == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (input == "Coke")
                {
                    productPrice = 1;
                }

                // With productPrice != 0 we check if the product is valid

                if (productPrice != 0)
                {
                    // With balance >= productPrice we check if we have enough money left

                    if (balance >= productPrice)
                    {
                        Console.WriteLine($"Purchased {input.ToLower()}"); // .toLower() converts all letters of the string to lower case 
                        balance -= productPrice; // update the balance
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {balance:F2}");

            // Another solution

            //bool isStarted = false;
            //bool isFinished = false;
            //double balance = 0;

            //while (!isStarted)
            //{
            //    string input = Console.ReadLine();
            //    double insertedCoin = 0;

            //    if (input == "Start")
            //    {
            //        isStarted = true;
            //    }
            //    else if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
            //    {
            //        insertedCoin = double.Parse(input);
            //        balance += insertedCoin;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Cannot accept {input}");
            //    }

            //}

            //while (!isFinished)
            //{
            //    string order = Console.ReadLine();

            //    double productPrice = 0;

            //    if (order == "End")
            //    {
            //        isFinished = true;
            //        Console.WriteLine($"Change: {balance:F2}");
            //    }
            //    else if (order == "Nuts")
            //    {
            //        productPrice = 2;
            //    }
            //    else if (order == "Water")
            //    {
            //        productPrice = 0.7;
            //    }
            //    else if (order == "Crisps")
            //    {
            //        productPrice = 1.5;
            //    }
            //    else if (order == "Soda")
            //    {
            //        productPrice = 0.8;
            //    }
            //    else if (order == "Coke")
            //    {
            //        productPrice = 1;
            //    }
            //    else
            //    {
            //        order = "Invalid";
            //        Console.WriteLine("Invalid product");
            //    }

            //    if (order != "End" && order != "Invalid")
            //    {
            //        if (balance >= productPrice)
            //        {
            //            balance -= productPrice;
            //            Console.WriteLine($"Purchased {order.ToLower()}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry, not enough money");
            //        }
            //    }
            }
    }
}
