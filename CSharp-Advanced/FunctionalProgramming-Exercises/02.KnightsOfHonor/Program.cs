using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main()
        {
            Action<string> print = x => Console.WriteLine("Sir " + x);

            var input = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
