using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input);
            }

            for (int currentStart = 0; currentStart < queue.Count; currentStart++)
            {
                bool isSolution = true;
                int fuel = 0;

                for (int nextPump = 0; nextPump < queue.Count; nextPump++)
                {
                    var currPump = queue.Dequeue();
                    queue.Enqueue(currPump);
                    int pumpFuel = currPump[0];
                    int nextPumpDistance = currPump[1];

                    fuel += pumpFuel - nextPumpDistance;
                    
                    if (fuel < 0)
                    {
                        isSolution = false;
                        currentStart += nextPump;
                        break;
                    }
                }

                if (isSolution)
                {
                    Console.WriteLine(currentStart);
                    break;
                }
            }
        }
    }
}
