using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
        this.FuelConsumption += 1.6;
    }

    public override string Drive(double distance)
    {
        string result = "Truck " + base.Drive(distance);
        return result;
    }

    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            var newFuel = this.FuelQuantity + liters * 0.95;

            if (newFuel > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity = newFuel;
            }
        }
    }

    public override string ToString()
    {
        return $"Truck: {FuelQuantity:f2}";
    }
}