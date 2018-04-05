using System;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                var line = int.Parse(Console.ReadLine());
                box.Add(line);
            }

            var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(swapIndexes);
            Console.WriteLine(box);
        }
    }
}
