using System;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double line = double.Parse(Console.ReadLine());
                box.Add(line);
            }

            double compare = double.Parse(Console.ReadLine());

            var result = box.CountBiggerElements(compare);
            Console.WriteLine(result);
        }
    }
}
