using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (input[0])
                {
                    case 1:
                        stack.Push(input[1]);
                        if (input[1] > max)
                        {
                            max = input[1];
                        }
                        break;
                    case 2:
                        int element = stack.Pop();

                        if (element == max && stack.Count > 0)
                        {
                            max = stack.Max();
                        }
                        else if (element == max && stack.Count == 0)
                        {
                            max = 0;
                        }
                        break;
                    case 3:
                        Console.WriteLine(max);
                        break;
                }
            }
        }
    }
}
