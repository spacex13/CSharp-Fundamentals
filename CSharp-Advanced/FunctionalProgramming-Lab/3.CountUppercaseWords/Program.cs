using System;
using System.Linq;

namespace _3.CountUppercaseWords
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => Char.IsUpper(x[0]))
                .ToList();

            foreach (var word in line)
            {
                Console.WriteLine(word);
            }
        }
    }
}
