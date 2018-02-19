using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CarSalesman
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {                  
                Engine engine = ReadEngine();
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                Car car = ReadCar(engines);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }

        static Car ReadCar(List<Engine> engines)
        {
            var line = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            var model = line[0];
            Engine engine = engines.First(e => e.Model == line[1]);
            var weight = "n/a";
            var color = "n/a";

            if (line.Length == 4)
            {
                weight = line[2];
                color = line[3];
            }
            else if (line.Length == 3)
            {
                bool isNum = int.TryParse(line[2], out _);
                if (isNum)
                {
                    weight = line[2];
                }
                else
                {
                    color = line[2];
                }
            }

            Car car = new Car(model, engine, weight, color);
            return car;
        }

        static Engine ReadEngine()
        {
            var line = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var model = line[0];
            var power = int.Parse(line[1]);
            var displacement = "n/a";
            var efficiency = "n/a";

            if (line.Length == 4)
            {
                displacement = line[2];
                efficiency = line[3];
            }
            else if (line.Length == 3)
            {
                bool isNum = int.TryParse(line[2], out _);
                if (isNum)
                {
                    displacement = line[2];
                }
                else
                {
                    efficiency = line[2];
                }
            }

            Engine engine = new Engine(model, power, displacement, efficiency);
            return engine;
        }
    }
}
