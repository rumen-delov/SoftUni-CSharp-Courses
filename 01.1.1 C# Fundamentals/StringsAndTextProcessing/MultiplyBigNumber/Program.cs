using System;
using System.Collections.Generic;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // The first input can be a really big number (0 to 10^50). 
            string bigIntNumber = Console.ReadLine();
             
            // The second input will be a single digit number (0 to 9) 
            byte singleDigitNumber = byte.Parse(Console.ReadLine());

            // You must display the product of these numbers
            // Note: do not use the BigInteger class

            if (singleDigitNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int currentBigIntDigit;
            int intermediateResult = 0;
            int intermediateResultLastDigit;
            int carry = 0;

            List<string> result = new List<string>();

            for (int i = bigIntNumber.Length - 1; i >= 0; i--)
            {
                //currentBigIntDigit = int.Parse(bigIntNumber[i].ToString());
                // or
                currentBigIntDigit = bigIntNumber[i] - '0'; // ASCII code of the digit - ASCII code of the zero digit 
                                                            // gives the difference as an int, which is the wanted result 

                intermediateResult = currentBigIntDigit * singleDigitNumber + carry;
                intermediateResultLastDigit = intermediateResult % 10;

                result.Add(intermediateResultLastDigit.ToString());

                if (intermediateResult > 9)
                {
                    carry = intermediateResult / 10; // integer division
                }
                else
                {
                    // We reset the carry for the next iteration in case
                    // the result of the intermediate calculation step was below 10 
                    // meaning it was a single digit (from 0 to 9)
                    carry = 0;
                }
            }

            // Check after the iteration of all digits of the big integer number is done 
            // if we need to put the last carry in front of the result
            if (carry > 0)
            {
                result.Add(carry.ToString());
            }

            result.Reverse();

            //Console.WriteLine(string.Join(string.Empty, result));
            // or
            Console.WriteLine(string.Concat(result));
        }
    }
}