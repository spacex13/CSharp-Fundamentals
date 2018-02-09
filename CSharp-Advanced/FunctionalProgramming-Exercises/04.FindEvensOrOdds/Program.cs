using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = numbers[0];
            int end = numbers[1];

            List<int> nums = new List<int>();

            string str = Console.ReadLine();

            Func<int, bool> odds = x => x % 2 != 0;

            for (int i = start; i <= end; i++)
            {
                if (str == "odd" && odds(i))
                {
                    nums.Add(i);
                }
                else if (str == "even" && odds(i) == false)
                {
                    nums.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
