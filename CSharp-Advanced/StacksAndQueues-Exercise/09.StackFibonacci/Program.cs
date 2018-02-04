using System;
using System.Collections.Generic;

namespace _09.StackFibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();
            stack.Push(0);
            stack.Push(1);

            for (int i = 0; i < n - 1; i++)
            {
                long firstPopped = stack.Pop();
                long secondPopped = stack.Peek();
                long calculated = firstPopped + secondPopped;
                stack.Push(firstPopped);
                stack.Push(calculated);
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
