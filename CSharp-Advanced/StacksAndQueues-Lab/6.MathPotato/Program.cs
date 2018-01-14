using System;
using System.Collections.Generic;

namespace _6.MathPotato
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input.Split());

            int cycle = 1;
            while (queue.Count > 1)
            {
                for (int i = 1; i < num; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }

        public static class PrimeTool
        {
            public static bool IsPrime(int candidate)
            {
                if ((candidate & 1) == 0)
                {
                    if (candidate == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
               
                for (int i = 3; (i * i) <= candidate; i += 2)
                {
                    if ((candidate % i) == 0)
                    {
                        return false;
                    }
                }
                return candidate != 1;
            }
        }
    }
}
