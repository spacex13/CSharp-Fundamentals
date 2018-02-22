using System;

namespace _1.RhombusOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                PrintRow(n, row);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(n, i);
            }
        }

        private static void PrintRow(int n, int rows)
        {
            for (int i = 1; i <= n - rows; i++)
            {
                Console.Write(" ");
            }

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
