using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12.StringMatrixRotation
{
    class Program
    {
        static void Main()
        {
            string rotationInfo = Console.ReadLine();
            string pattern = @"[\d]+";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(rotationInfo);
            int degrees = int.Parse(match.ToString());

            string line;
            List<string> lines = new List<string>();

            while ((line = Console.ReadLine()) != "END")
            {
                lines.Add(line);
            }

            int columns = 0;
            int rows = lines.Count;

            foreach (var word in lines)
            {
                if (word.Length > columns)
                    columns = word.Length;
            }

            char[,] matrix = new char[rows, columns];
            int count = 0;

            if (degrees > 360)
            {
                degrees %= 360;
            }

            switch (degrees)
            {
                case 0:
                    count = 0;
                    break;
                case 90:
                    count = 1;
                    break;
                case 180:
                    count = 2;
                    break;
                case 270:
                    count = 3;
                    break;
            }

            for (int i = 0; i < rows; i++)
            {
                string currWord = lines[i];
                for (int j = 0; j < columns; j++)
                {
                    if (j >= currWord.Length)
                    {
                        matrix[i, j] = ' ';
                    }
                    else
                    {
                        matrix[i, j] = currWord[j];
                    }
                }
            }
            
            for (int i = 0; i < count; i++)
            {
                matrix = ReverseMatrix(matrix);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static char[,] ReverseMatrix(char[,] matrix)
        {
            int oldRows = matrix.GetLength(0);
            int oldCols = matrix.GetLength(1);
            char[,] newMatrix = new char[oldCols, oldRows];

            int newRows = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int newCols = 0;
                for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                {
                    newMatrix[newRows, newCols] = matrix[j, i];
                    newCols++;
                }

                newRows++;
            }

            return newMatrix;
        }
    }
}
