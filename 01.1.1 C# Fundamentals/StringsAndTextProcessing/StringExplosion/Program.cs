using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Explosions are marked with '>'
            // - Immediately after the mark, there will be an integer, 
            // which signifies the strength of the explosion.
            // - If you find another explosion mark ('>') while you’re deleting characters, 
            // you should add the strength to your previous explosion.
            // - You should remove x characters (where x is the strength of the explosion), 
            // starting after the punch character ('>').
            // - You should not delete the explosion character – '>', but
            // you should delete the integers, which represent the strength.

            string bombField = Console.ReadLine();

            int strength = 0;

            for (int i = 0; i < bombField.Length; i++)
            {               
                if (bombField[i] == '>')
                {
                    strength += bombField[i + 1] - '0';
                    //    or
                    //strength += int.Parse(bombField[i + 1].ToString());                
                }
                else if (strength > 0)
                {
                    bombField = bombField.Remove(i, 1);
                    strength--;
                    i--;
                }
            }

            // Print what is left from the string after explosions
            Console.WriteLine(bombField);
        }
    }
}
