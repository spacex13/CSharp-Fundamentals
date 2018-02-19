using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        double n = line[0];
        double m = line[1];
        List<Rectangle> rectangles = new List<Rectangle>();

        for (int i = 0; i < n; i++)
        {
            var info = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var id = info[0];
            var width = double.Parse(info[1]);
            var height = double.Parse(info[2]);
            var x = double.Parse(info[3]);
            var y = double.Parse(info[4]);

            Rectangle rectangle = new Rectangle(id, width, height, x, y);
            rectangles.Add(rectangle);
        }

        for (int i = 0; i < m; i++)
        {
            var compare = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Rectangle r1 = rectangles.FirstOrDefault(r => r.Id == compare[0]);
            Rectangle r2 = rectangles.FirstOrDefault(r => r.Id == compare[1]);

            Console.WriteLine(r1.Intersect(r2).ToString().ToLower());
        }
    }
}

