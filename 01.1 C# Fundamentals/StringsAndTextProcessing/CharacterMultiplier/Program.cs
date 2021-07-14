using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int result = CharacterMultiplier(input[0], input[1]);

            Console.WriteLine(result);
        }

        private static int CharacterMultiplier(string str1, string str2)
        {
            int sum = 0;

            int minLength = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += str1[i] * str2[i]; 
            }

            if (str1.Length > str2.Length)
            {
                for (int i = str2.Length; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else if (str2.Length > str1.Length)
            {
                for (int i = str1.Length; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }

            return sum;
        }
    }
}
