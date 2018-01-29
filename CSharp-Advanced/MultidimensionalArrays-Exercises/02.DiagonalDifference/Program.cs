using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long[,] matrix = new long[n, n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            long primary = 0;
            long secondary = 0;

            for (int i = 0; i < n; i++)
            {
                primary += matrix[i, i];
                secondary += matrix[n - 1 - i, i];
            }

            long result = Math.Abs(primary - secondary);
            Console.WriteLine(result);
        }
    }
}
