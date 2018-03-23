using System;

class Program
{
    static void Main()
    {
        Scale<int> scale = new Scale<int>(5, 6);
        Console.WriteLine(scale.GetHeavier());
    }
}