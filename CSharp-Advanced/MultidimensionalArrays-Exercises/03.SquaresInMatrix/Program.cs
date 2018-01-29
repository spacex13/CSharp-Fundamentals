using System;
using System.Linq;

namespace _03.SquaresInMatrix
{
    class Program
    {
        static void Main()
        {

            int[] input = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char first = matrix[row, col];
                    char second = matrix[row, col + 1];
                    char third = matrix[row + 1, col];
                    char fourth = matrix[row + 1, col + 1];

                    bool equal = first == second && second == third && third == fourth;
                    if (equal)
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
