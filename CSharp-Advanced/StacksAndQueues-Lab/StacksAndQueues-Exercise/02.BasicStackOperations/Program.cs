using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int s = input[1];
            int x = input[2];

            Stack<int> stack = new Stack<int>();

            foreach (var num in nums)
            {
                stack.Push(num);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else 
            {
                while (stack.Count > 1)
                {
                    int last = stack.Pop();
                    int lastLast = stack.Pop();
                    stack.Push(Math.Min(last, lastLast));
                }
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
