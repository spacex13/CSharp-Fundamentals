using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParentheses
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            char[] leftBr = { '{', '(', '[' };
            char[] rightBr = { '}', ')', ']' };

            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;

            if (stack.Count % 2 != 0)
            {
                isBalanced = false;
            }
            else
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (leftBr.Contains(line[i]))
                    {
                        stack.Push(line[i]);
                    }
                    else if (rightBr.Contains(line[i]))
                    {
                        if (stack.Count == 0)
                        {
                            isBalanced = false;
                            break;
                        }

                        char lastElement = stack.Pop();
                        int openingIndex = Array.IndexOf(leftBr, lastElement);
                        int closingIndex = Array.IndexOf(rightBr, line[i]);

                        if (openingIndex != closingIndex)
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
