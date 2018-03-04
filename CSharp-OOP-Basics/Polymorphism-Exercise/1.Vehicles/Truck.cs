public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption)
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
        this.FuelQuantity += liters * 95 / 100;
    }

    public override string ToString()
    {
        return $"Truck: {FuelQuantity:f2}";
    }
}