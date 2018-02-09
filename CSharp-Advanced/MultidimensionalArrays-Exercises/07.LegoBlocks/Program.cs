using System;
using System.Linq;

namespace _07.LegoBlocks
{
    class Program
    {
        static int[][] FillJaggedArray(int n)
        {
            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[i] = new int[rowElements.Length];
                

                for (int j = 0; j < rowElements.Length; j++)
                {
                    jaggedArray[i][j] = rowElements[j];
                }
            }

            return jaggedArray;
        }

        static bool CheckIfFits(int[][] firstArray, int[][] secondReversed, int n)
        {
            for (int i = 0; i < 1; i++)
            {
                int arrRow1Len = firstArray[i].Length;
                int arrRow2Len = secondReversed[i].Length;
                int sum1 = arrRow1Len + arrRow2Len;

                for (int j = 1; j < n; j++)
                {
                    arrRow1Len = firstArray[j].Length;
                    arrRow2Len = secondReversed[j].Length;
                    int sum2 = arrRow1Len + arrRow2Len;

                    if (sum1 != sum2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] firstArray = FillJaggedArray(n);
            int[][] secondArray = FillJaggedArray(n);

            int[][] secondReversed = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] arr = secondArray[i];
                secondReversed[i] = arr.Reverse().ToArray();
            }

            bool fits = CheckIfFits(firstArray, secondReversed, n);

            if (fits)
            {
                int[][] rectangle = CreateRectangleMatrix(firstArray, secondReversed, n);

                PrintMatrix(n, rectangle);
            }
            else
            {
                int totalCells = TotalCells(firstArray, secondReversed, n);
                Console.WriteLine($"The total number of cells is: {totalCells}");
            }
        }

        static int TotalCells(int[][] firstArray, int[][] secondReversed, int n)
        {
            int cells = 0;

            for (int row = 0; row < n; row++)
            {
                cells += firstArray[row].Length + secondReversed[row].Length;
            }

            return cells;
        }

        static void PrintMatrix(int n, int[][] rectangle)
        {
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine($"[{string.Join(", ", rectangle[i])}]");
            }
        }

        static int[][] CreateRectangleMatrix(int[][] firstArray, int[][] secondReversed, int n)
        {
            int[][] rectangle = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] arr1 = firstArray[row];
                int[] arr2 = secondReversed[row];
                int totalColumns = arr1.Length + arr2.Length;
                int count = 0;

                rectangle[row] = new int[totalColumns];

                for (int col = 0; col < totalColumns; col++)
                {
                    if (col >= arr1.Length)
                    {
                        rectangle[row][col] = arr2[count];
                        count++;
                    }
                    else
                    {
                        rectangle[row][col] = arr1[col];
                    }
                }
            }

            return rectangle;
        }
    }
}
