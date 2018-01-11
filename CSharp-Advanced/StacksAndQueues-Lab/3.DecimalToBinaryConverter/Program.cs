using System;
using System.Collections.Generic;

namespace _3.DecimalToBinaryConverter
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            if (num == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while (num != 0)
                {
                    stack.Push(num % 2);
                    num /= 2;
                }
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());    
            }
            Console.WriteLine();
        }
    }
}
