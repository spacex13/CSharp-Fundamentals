using System;

public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;

        if (FuelQuantity > TankCapacity)
        {
            this.FuelQuantity = 0;
        }
    }

    public double FuelQuantity { get; protected set; }

    public double FuelConsumption { get; set; }

    public double TankCapacity { get; protected set; }

    public virtual string Drive(double distance)
    {
        var fuelNeeded = distance * this.FuelConsumption;

        if (fuelNeeded > this.FuelQuantity)
        {
            return "needs refueling";
        }
        else
        {
            this.FuelQuantity -= fuelNeeded;
            return $"travelled {distance} km";
        }
    }

    public virtual void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            var newFuel = this.FuelQuantity + liters;

            if (newFuel > this.TankCapacity)
            {
                System.Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity = newFuel;
            }
        }
    }
}