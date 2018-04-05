using System;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                box.Add(line);                
            }

            var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(swapIndexes);
            Console.WriteLine(box);
        }
    }
}
