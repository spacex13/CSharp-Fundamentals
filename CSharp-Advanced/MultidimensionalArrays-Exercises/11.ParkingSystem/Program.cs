using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _11.ParkingSystem
{
    class Program
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int r = dimensions[0];
            int c = dimensions[1];

            byte[][] parking = new byte[r][];
            string command;
            while ((command = Console.ReadLine()) != "stop")
            {
                var info = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse).ToArray();
                int entryRow = info[0];
                int x = info[1];
                int y = info[2];

                if (parking[x] == null)
                {
                    parking[x] = new byte[c];
                }

                if (parking[x][y] == 0)
                {
                    parking[x][y] = 1;
                    int distance = CalcDistance(x, y, entryRow);
                    Console.WriteLine(distance);
                }
                else
                {
                    int count = 1;
                    while (true)
                    {
                        int lowerCell = y - count;
                        int upperCell = y + count;

                        if (lowerCell < 1 && upperCell > c - 1)                     // if cells are out of bounds
                        {
                            Console.WriteLine($"Row {x} full");
                            break;
                        }
                        if (lowerCell > 0 && parking[x][lowerCell] == 0)           // if cell is inside of the row and free
                        {
                            parking[x][lowerCell] = 1;
                            int distance = CalcDistance(x, lowerCell, entryRow);
                            Console.WriteLine(distance);
                            break;
                        }
                        if (upperCell < c && parking[x][upperCell] == 0)            // if cell is inside of the row and free
                        {
                            parking[x][upperCell] = 1;
                            int distance = CalcDistance(x, upperCell, entryRow);
                            Console.WriteLine(distance);
                            break;
                        }

                        count++;
                    }
                }
            }
        }

        static int CalcDistance(int x, int y, int entryRow)
        {
            int distance = 0;
            distance += Math.Abs(x - entryRow);
            distance += y + 1;

            return distance;
        }
    }
}
