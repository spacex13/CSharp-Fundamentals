using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> func = (x, y) => x % y == 0;
            List<int> sequence = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool divisible = true;

                foreach (var num in numbers)
                {
                    if (func(i, num) == false)
                    {
                        divisible = false;
                        break;
                    }
                }

                if (divisible)
                    sequence.Add(i);
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
