using System;
using System.Linq;

namespace _2.SquareWithMaximumSum
{
    class Program
    {
        static void Main()
        {
            var rowsAndColsInput = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.None).Select(int.Parse)
                .ToArray();
            int rows = rowsAndColsInput[0];
            int cols = rowsAndColsInput[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = 0;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int tempSum = matrix[row, col] + matrix[row, col + 1]
                      + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine(matrix[maxRowIndex, maxColIndex] + " " + matrix[maxRowIndex, maxColIndex + 1]);
            Console.WriteLine(matrix[maxRowIndex + 1, maxColIndex] + " " + matrix[maxRowIndex + 1, maxColIndex + 1]);
            Console.WriteLine(maxSum);
        }
    }
}
