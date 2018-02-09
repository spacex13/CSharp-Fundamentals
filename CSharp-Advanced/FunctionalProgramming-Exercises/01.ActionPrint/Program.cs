using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main()
        {
            Action<string> print = x => Console.WriteLine(x);

            var input = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
