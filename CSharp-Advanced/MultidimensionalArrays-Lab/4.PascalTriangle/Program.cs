using System;

namespace _4.PascalTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedArray[i] = new long[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                int len = jaggedArray[i].Length;
                jaggedArray[i][0] = 1;
                jaggedArray[i][len - 1] = 1;

                if (i >= 2)
                {
                    for (int j = 1; j < len - 1; j++)
                    {
                        jaggedArray[i][j] = jaggedArray[i - 1][j - 1] + jaggedArray[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
