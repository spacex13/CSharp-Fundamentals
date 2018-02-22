using System;

namespace _4.HotelReservation
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split();
            var pricePerDay = decimal.Parse(line[0]);
            var days = int.Parse(line[1]);
            var season = line[2];
            var discount = "None";

            if (line.Length > 3)
            {
                discount = line[3];
            }

            PriceCalculator calculator = new PriceCalculator(pricePerDay, days, season, discount);
            Console.WriteLine($"{calculator.TotalPrice():f2}");
        }
    }
}
