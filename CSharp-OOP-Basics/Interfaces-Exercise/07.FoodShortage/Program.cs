using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<IBuyer> amountOfFood = new List<IBuyer>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split();
            if (line.Length == 4)
            {
                Citizen citizen = new Citizen(line[0], Int32.Parse(line[1]), line[2], DateTime.ParseExact(line[3], "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo));
                amountOfFood.Add(citizen);
            }
            else
            {
                Rebel rebel = new Rebel(line[0], int.Parse(line[1]), line[2]);
                amountOfFood.Add(rebel);
            }
        }

        string buyer;
        while ((buyer = Console.ReadLine()) != "End")
        {
            if (amountOfFood.Any(p => p.Name == buyer))
            {
                IBuyer person = amountOfFood.First(p => p.Name == buyer);
                person.BuyFood();
            }
        }

        int food = 0;
        foreach (var b in amountOfFood)
        {
            food += b.Food;
        }
        Console.WriteLine(food);
    }
}

