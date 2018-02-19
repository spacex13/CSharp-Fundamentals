using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var model = carInfo[0];
                var fuel = double.Parse(carInfo[1]);
                var fuelConsumption = double.Parse(carInfo[2]);
                Car car = new Car(model, fuel, fuelConsumption);
                
                cars.Add(car);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var info = command.Split();
                var carModel = info[1];
                var amountOfKm = int.Parse(info[2]);
                
                Car car = cars.First(c => c.Model == carModel);
                car.MoveCar(amountOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
}
