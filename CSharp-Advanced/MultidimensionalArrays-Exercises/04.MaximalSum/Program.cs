using System;
using System.Linq;

namespace _04.MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = 0;
            int rowIndex = 0;
            int colIndex = 0;

            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < m - 2; col++)
                {
                    int currSum = GetMatrixSum(matrix, row, col);

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);
            PrintMaxMatrix(matrix, rowIndex, colIndex);
        }

        static int GetMatrixSum(int[,] matrix, int row, int col)
        {
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += matrix[row + i, col + j];
                }
            }

            return sum;
        }

        static void PrintMaxMatrix(int[,] matrix, int rowIndex, int colIndex)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.Write(matrix[rowIndex + i, colIndex + j]);
                    }
                    else
                    {
                        Console.Write(matrix[rowIndex + i, colIndex + j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
