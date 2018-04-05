using System;

namespace _05.GenericCountMethodString
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

            var compare = Console.ReadLine();

            var result = box.CountBiggerElements(compare);
            Console.WriteLine(result);
        }
    }
}
