using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string encryptedText = string.Empty;
            int charCode = 0;

            for (int i = 0; i < text.Length; i++)
            {
                charCode = text[i] + 3;
                encryptedText += (char)charCode;
            }
                        
            Console.WriteLine(encryptedText);
        }
    }
}
