using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main()
        {
            Func<int, int, int> findMin = (x, y) =>
            {
                if (x > y)
                {
                    return y;
                }
                return x;
            };

            var numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int minValue = Int32.MaxValue;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentMin = findMin(numbers[0], numbers[i]);

                minValue = findMin(minValue, currentMin);
            }

            Console.WriteLine(minValue);
        }
    }
}
