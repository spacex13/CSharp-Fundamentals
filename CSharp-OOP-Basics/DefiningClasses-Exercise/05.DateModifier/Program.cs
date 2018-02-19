using System;

public class Program
{
    public static void Main()
    {
        var startDate = DateTime.Parse(Console.ReadLine());
        var endDate = DateTime.Parse(Console.ReadLine());

        DateModifier calc = new DateModifier();
        calc.startDate = startDate;
        calc.endDate = endDate;

        var days = calc.DaywBetweenDates();
        Console.WriteLine(days);
    }
}
