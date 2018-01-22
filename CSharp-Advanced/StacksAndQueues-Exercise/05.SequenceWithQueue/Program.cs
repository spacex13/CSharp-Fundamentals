using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SequenceWithQueue
{
    class Program
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var sequence = new Queue<long>();
            var seqNums = new List<long> {n};

            sequence.Enqueue(n);
            while (seqNums.Count < 50)
            {
                var firstItem = sequence.Peek() + 1;
                sequence.Enqueue(firstItem);
                var secondItem = sequence.Peek() * 2 + 1;
                sequence.Enqueue(secondItem);
                var thirdItem = firstItem + 1;
                sequence.Enqueue(thirdItem);

                sequence.Dequeue();
                seqNums.Add(firstItem);
                seqNums.Add(secondItem);
                seqNums.Add(thirdItem);
            }

            Console.WriteLine(string.Join(" ", seqNums.Take(50)));
        }
    }
}
