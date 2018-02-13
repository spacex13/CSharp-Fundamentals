using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = "";

            Func<int, int> addition = x => x += 1;
            Func<int, int> subtract = x => x -= 1;
            Func<int, int> multiply = x => x *= 2;
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(addition).ToArray();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtract).ToArray();
                        break;
                    case "multiply":
                        numbers = numbers.Select(multiply).ToArray();
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
            }
        }
    }
}
