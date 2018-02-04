using System;
using System.Linq;

namespace _08.RadioactiveMutantVampireBunnies
{
    class Program
    {
        public static int playerRow;
        public static int playerCol;

        public static int lastPlayerRow;
        public static int lastPlayerCol;

        static char[,] ReadMatrix(int n, int m)
        {
            char[,] matrix = new char[n, m];

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();

                for (int col = 0; col < m; col++)
                {
                    char ch = line[col];
                    matrix[row, col] = ch;

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            return matrix;
        }

        static char[,] BunniesSpead(char[,] matrix, int n, int m)
        {
            char[,] copyMatrix =  (char[,])matrix.Clone();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (col - 1 >= 0)
                        {
                            copyMatrix[row, col - 1] = 'B';
                        }
                        if (col + 1 < m)
                        {
                            copyMatrix[row, col + 1] = 'B';
                        }
                        if (row - 1 >= 0)
                        {
                            copyMatrix[row - 1, col] = 'B';
                        }
                        if (row + 1 < n)
                        {
                            copyMatrix[row + 1, col] = 'B';
                        }
                    }
                }
            }

            matrix = (char[,])copyMatrix.Clone();

            return matrix;
        }

        static void MovePlayer(char[,] matrix, char moveTo, int m, int n)
        {
            matrix[playerRow, playerCol] = '.';

            lastPlayerRow = playerRow;
            lastPlayerCol = playerCol;

            switch (moveTo)
            {
                case 'U':
                    playerRow -= 1;
                    break;
                case 'D':
                    playerRow += 1;
                    break;
                case 'L':
                    playerCol -= 1;
                    break;
                case 'R':
                    playerCol += 1;
                    break;
            }
        }

        static bool CheckIfPlayerIsFree(int m, int n)
        {
            if (playerRow >= n || playerRow < 0 || playerCol >= m || playerCol < 0)
            {
                return true;
            }

            return false;
        }

        static void Main()
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = sizes[0];
            int m = sizes[1];

            char[,] matrix = ReadMatrix(n, m);
            string commands = Console.ReadLine();
            int moveCount = 0;

            bool isWon = false;
            bool isDead = false;

            while (true)
            {
                char moveTo = commands[moveCount];
                MovePlayer(matrix, moveTo, m, n);
                matrix = BunniesSpead(matrix, n, m);

                if (CheckIfPlayerIsFree(m, n))
                {
                    isWon = true;
                    break;
                }

                if (matrix[playerRow, playerCol] == 'B')
                {
                    isDead = true;
                    lastPlayerRow = playerRow;
                    lastPlayerCol = playerCol;
                    break;
                }

                matrix[playerRow, playerCol] = 'P';

                moveCount++;
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

            if (isWon)
            {
                Console.WriteLine($"won: {lastPlayerRow} {lastPlayerCol}");
            }
            else if (isDead)
            {
                Console.WriteLine($"dead: {lastPlayerRow} {lastPlayerCol}");
            }
        }
    }
}
