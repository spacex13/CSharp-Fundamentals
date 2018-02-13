using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Func<int, int, bool> divisibleByN = (x, N) => x % N == 0;

            numbers.Reverse();

            for (int num = 0; num < numbers.Count; num++)
            {
                if (divisibleByN(numbers[num], n))
                {
                    numbers.Remove(numbers[num]);
                    num--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
