using System;

namespace SumAndProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int product = 0;

            bool flag = false;


            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            sum = a + b + c + d;
                            product = a * b * c * d;

                            if ((sum == product) && (n % 10 == 5))
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                flag = true;
                            }
                            else if ((Math.Floor(1.0*product/sum) == 3) && (n % 3 == 0))
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                // Console.WriteLine(d*1000+c*100+b*10+a);
                                flag = true;
                            }

                            if (flag)
                            {
                                break;
                            }
                        }

                        if (flag)
                        {
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Nothing found");
            }


        }
    }
}
