using System;
using System.Linq;

namespace _09.Crossfire
{
    class Program
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int n = dimensions[0];
            int m = dimensions[1];

            string[][] matrix = FillMatrix(n, m);
            string command;

            while ((command = Console.ReadLine()) != "Nuke it from orbit")
            {
                int[] coordinates = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToArray();

                int nukeRow = coordinates[0];
                int nukeCol = coordinates[1];
                int nukeRadius = coordinates[2];

                matrix = NukeCross(nukeRadius, nukeRow, nukeCol, ref matrix);
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(string[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row.Where(x => x != "")));
            }
        }

        static string[][] FillMatrix(int n, int m)
        {
            string[][] matrix = new string[n][];
            int count = 1;

            for (int row = 0; row < n; row++)
            {
                matrix[row] = new string[m];

                for (int col = 0; col < m; col++)
                {
                    matrix[row][col] = count.ToString();
                    count++;
                }
            }

            return matrix;
        }

        static bool IsInMatrix(int row, int col, string[][] matrix)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }

        static string[][] NukeCross(int nukeRadius, int nukeRow, int nukeCol, ref string[][] matrix)
        {
            for (int rowIndex = nukeRow - nukeRadius; rowIndex <= nukeRow + nukeRadius; rowIndex++)
            {
                if (IsInMatrix(rowIndex, nukeCol, matrix))
                {
                    matrix[rowIndex][nukeCol] = "";
                }
            }

            for (int colIndex = nukeCol - nukeRadius; colIndex <= nukeCol + nukeRadius; colIndex++)
            {
                if (IsInMatrix(nukeRow, colIndex, matrix))
                {
                    matrix[nukeRow][colIndex] = "";
                }
            }

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                if (matrix[rowIndex].Any(c => c == ""))
                {
                    matrix[rowIndex] = matrix[rowIndex].Where(n => n != "").ToArray();
                }

                if (matrix[rowIndex].Length < 1)
                {
                    matrix = matrix.Take(rowIndex).Concat(matrix.Skip(rowIndex + 1)).ToArray();
                    rowIndex--;
                }
            }

            return matrix;
        }

        //static string[][] AnotherNukeCrossMethod(int nukeRadius, int nukeRow, int nukeCol, ref string[][] matrix)
        //{
        //    if (IsInMatrix(nukeRow, nukeCol, matrix))
        //    {
        //        matrix[nukeRow][nukeCol] = "";
        //    }

        //    for (int j = 1; j <= nukeRadius; j++)
        //    {
        //        int leftCol = nukeCol - j;
        //        int rightCol = nukeCol + j;

        //        int upRow = nukeRow - j;
        //        int downRow = nukeRow + j;

        //        if (IsInMatrix(nukeRow, leftCol, matrix))
        //        {
        //            matrix[nukeRow][leftCol] = "";
        //        }

        //        if (IsInMatrix(nukeRow, rightCol, matrix))
        //        {
        //            matrix[nukeRow][rightCol] = "";
        //        }

        //        if (IsInMatrix(upRow, nukeCol, matrix))
        //        {
        //            matrix[upRow][nukeCol] = "";
        //        }

        //        if (IsInMatrix(downRow, nukeCol, matrix))
        //        {
        //            matrix[downRow][nukeCol] = "";
        //        }
        //    }

        //    for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
        //    {
        //        if (matrix[rowIndex].Any(c => c == ""))
        //        {
        //            matrix[rowIndex] = matrix[rowIndex].Where(n => n != "").ToArray();
        //        }

        //        if (matrix[rowIndex].Length < 1)
        //        {
        //            matrix = matrix.Take(rowIndex).Concat(matrix.Skip(rowIndex + 1)).ToArray();
        //            rowIndex--;
        //        }
        //    }

        //    return matrix;
        //}
    }
}