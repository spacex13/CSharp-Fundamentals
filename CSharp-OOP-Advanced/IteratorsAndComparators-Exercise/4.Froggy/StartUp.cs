using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        Lake lake = new Lake(stones);

        Console.WriteLine(string.Join(", ", lake));
    }
}