using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RawData
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split();
                var model = info[0];
                var engineSpeed = int.Parse(info[1]);
                var enginePower = int.Parse(info[2]);
                var cargoWeight = int.Parse(info[3]);
                var cargoType = info[4];
                var tire1Pressure = double.Parse(info[5]);
                var tire1Age = int.Parse(info[6]);
                var tire2Pressure = double.Parse(info[5]);
                var tire2Age = int.Parse(info[6]);
                var tire3Pressure = double.Parse(info[5]);
                var tire3Age = int.Parse(info[6]);
                var tire4Pressure = double.Parse(info[5]);
                var tire4Age = int.Parse(info[6]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire tire1 = new Tire(tire1Age, tire1Pressure);
                Tire tire2 = new Tire(tire2Age, tire2Pressure);
                Tire tire3 = new Tire(tire3Age, tire3Pressure);
                Tire tire4 = new Tire(tire4Age, tire4Pressure);
                Car car = new Car(model, engine, cargo, tire1, tire2, tire3, tire4);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == "fragile" &&
                (c.Tire1.TirePressure < 1 || c.Tire2.TirePressure < 1 || c.Tire3.TirePressure < 1 || c.Tire4.TirePressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
