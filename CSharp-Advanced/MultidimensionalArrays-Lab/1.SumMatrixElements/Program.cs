using System;
using System.Linq;

namespace MultidimensionalArrays_Lab
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new []{", "}, StringSplitOptions.None).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var info = Console.ReadLine().Split(new [] {", "}, StringSplitOptions.None).Select(int.Parse).ToArray();
                for (int col   = 0; col < cols; col++)
                {
                    matrix[row, col] = info[col];
                }
            }

            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
