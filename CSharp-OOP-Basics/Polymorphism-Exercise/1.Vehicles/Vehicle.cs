public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity { get; protected set; }

    public double FuelConsumption { get; protected set; }

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
        this.FuelQuantity += liters;
    }
}