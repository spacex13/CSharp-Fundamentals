using System;

class Program
{
    static void Main()
    {
        Car car = ReadCar();
        Truck truck = ReadTruck();
        Bus bus = ReadBus();

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var line = Console.ReadLine().Split();

            switch (line[0])
            {
                case "DriveEmpty":
                    double distance = double.Parse(line[2]);
                    var result = bus.Drive(distance);
                    Console.WriteLine(result);
                    break;
                case "Drive":
                    distance = double.Parse(line[2]);
                    switch (line[1])
                    {
                        case "Car":
                            result = car.Drive(distance);
                            Console.WriteLine(result);
                            break;
                        case "Truck":
                            result = truck.Drive(distance);
                            Console.WriteLine(result);
                            break;
                        case "Bus":
                            bus.FuelConsumption += 1.4;
                            result = bus.Drive(distance);
                            Console.WriteLine(result);
                            bus.FuelConsumption -= 1.4;
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
                        case "Bus":
                            bus.Refuel(liters);
                            break;
                    }
                    break;
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    public static Car ReadCar()
    {
        var carInfo = Console.ReadLine().Split();
        var carFuel = double.Parse(carInfo[1]);
        var carFuelConsumption = double.Parse(carInfo[2]);
        var carTankCapacity = double.Parse(carInfo[3]);

        return new Car(carFuel, carFuelConsumption, carTankCapacity);
    }

    public static Truck ReadTruck()
    {
        var truckInfo = Console.ReadLine().Split();
        var truckFuel = double.Parse(truckInfo[1]);
        var truckFuelConsumption = double.Parse(truckInfo[2]);
        var truckTankCapacity = double.Parse(truckInfo[3]);

        return new Truck(truckFuel, truckFuelConsumption, truckTankCapacity);
    }

    public static Bus ReadBus()
    {
        var busInfo = Console.ReadLine().Split();
        var busFuel = double.Parse(busInfo[1]);
        var busFuelConsumption = double.Parse(busInfo[2]);
        var busTankCapacity = double.Parse(busInfo[3]);

        return new Bus(busFuel, busFuelConsumption, busTankCapacity);
    }
}

