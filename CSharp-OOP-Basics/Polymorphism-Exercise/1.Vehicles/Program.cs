using System;

class Program
{
    static void Main()
    {
        var carInfo = Console.ReadLine().Split();
        var carFuel = double.Parse(carInfo[1]);
        var carFuelConsumption = double.Parse(carInfo[2]);

        Car car = new Car(carFuel, carFuelConsumption);

        var truckInfo = Console.ReadLine().Split();
        var truckFuel = double.Parse(truckInfo[1]);
        var truckFuelConsumption = double.Parse(truckInfo[2]);

        Truck truck = new Truck(truckFuel, truckFuelConsumption);

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var line = Console.ReadLine().Split();

            switch(line[0])
            {
                case "Drive":
                    double distance = double.Parse(line[2]);
                    switch(line[1])
                    {
                        case "Car":
                            var result = car.Drive(distance);
                            Console.WriteLine(result);
                            break;
                        case "Truck":
                            result = truck.Drive(distance);
                            Console.WriteLine(result);
                            break;
                    }
                    break;
                case "Refuel":
                    double liters = double.Parse(line[2]);
                    switch (line[1])
                    {
                        case "Car":
                            car.Refuel(liters);
                            break;
                        case "Truck":
                            truck.Refuel(liters);
                            break;
                    }
                    break;
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}