using System;
using System.Linq;

namespace _2.PointInRectangle
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point p1 = new Point(line[0], line[1]);
            Point p2 = new Point(line[2], line[3]);

            Rectangle rectangle = new Rectangle(p1, p2);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = pointInfo[0];
                int y = pointInfo[1];
                Point point = new Point(x, y);
                Console.WriteLine(rectangle.Contains(point) ? "True":"False");
            }
        }
    }
}
