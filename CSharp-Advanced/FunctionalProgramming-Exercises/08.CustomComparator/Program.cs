using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> comparator = (x, y) =>
            (x % 2 == 0 && y % 2 != 0) ? -1 :
            (x % 2 != 0 && y % 2 == 0) ? 1 :
             x.CompareTo(y);

            Array.Sort<int>(numbers, new Comparison<int>(comparator));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
