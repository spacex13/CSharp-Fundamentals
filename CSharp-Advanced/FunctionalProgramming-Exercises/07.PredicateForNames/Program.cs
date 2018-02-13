using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> fitsLength = (name, len) =>
            {
                if (name.Length <= len)
                    return true;
                return false;
            };

            Action<string> print = x => Console.WriteLine(x);

            foreach (var name in names)
            {
                if (fitsLength(name, length))
                {
                    print(name);
                }
            }
        }
    }
}
