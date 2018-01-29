using System;
using System.Linq;

namespace _01.MatrixOfPalindromes
{
    class Program
    {
        static void Main()
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    char firstLetter = alphabet[row];
                    char middleLetter = alphabet[row + col];
                    char lastLetter = alphabet[row];
                    string palindrome = firstLetter.ToString() + middleLetter.ToString() + lastLetter.ToString();

                    matrix[row, col] = palindrome;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
