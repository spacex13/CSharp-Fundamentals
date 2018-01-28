using System;
using System.Linq;

namespace _3.GroupNumbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();

            int[] length = new int[3];

            for (int i = 0; i < input.Length; i++)
            {
                length[Math.Abs(input[i] % 3)]++;
            }

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[length[0]];
            jaggedArray[1] = new int[length[1]];
            jaggedArray[2] = new int[length[2]];

            int[] offsets = new int[3];

            foreach (var number in input)
            {
                int remainder = number % 3;
                remainder = Math.Abs(remainder);
                int index = offsets[remainder];
                jaggedArray[remainder][index] = number;
                offsets[remainder]++;
            }

            for (int i = 0; i < length.Length; i++)
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
