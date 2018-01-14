using System;
using System.Collections.Generic;

namespace _5.HotPotato
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input.Split());

            while (queue.Count > 1)
            {
                for (int i = 1; i < num; i++)
                {
                    string last = queue.Dequeue();
                    queue.Enqueue(last);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
