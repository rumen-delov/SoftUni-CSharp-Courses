using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] parantheses = Console.ReadLine().ToCharArray();
            
            // Odd number of brackets cannot be balanced
            if (parantheses.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<int> stack = new Stack<int>();

            int currentBracket = 0;
            int openingBracket = 0;
            int closingBracket = 0;

            for (int i = 0; i < parantheses.Length; i++)
            {
                currentBracket = parantheses[i];

                if (stack.Count == 0)
                {
                    // Bracket sequence should start with an opening bracket
                    if (currentBracket == 123 || 
                        currentBracket == 91 ||
                        currentBracket == 40)
                    {
                        stack.Push(parantheses[i]);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

                openingBracket = stack.Peek();

                switch (openingBracket)
                {
                    // '{'
                    case 123:
                        closingBracket = 125; // '}'
                        break;
                    // '('
                    case 91:
                        closingBracket = 93; // ')'
                        break;
                    // '['
                    case 40:
                        closingBracket = 41; // ']'
                        break;
                    default:
                        closingBracket = 0;
                        break;
                }

                if (currentBracket != closingBracket)
                {
                    stack.Push(currentBracket);
                }
                else
                {
                    stack.Pop();
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }           
        }
    }
}