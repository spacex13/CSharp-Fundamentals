using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
    }

    private double distanceTraveled;

    public double DistanceTraveled
    {
        get { return distanceTraveled; }
        set { distanceTraveled = value; }
    }

    public void MoveCar(int kmTravelled)
    {
        double currentKm = fuelAmount / fuelConsumption;
        if (currentKm >= kmTravelled)
        {
            DistanceTraveled += kmTravelled;
            var usedFuel = kmTravelled * fuelConsumption;
            fuelAmount -= usedFuel;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }


}
