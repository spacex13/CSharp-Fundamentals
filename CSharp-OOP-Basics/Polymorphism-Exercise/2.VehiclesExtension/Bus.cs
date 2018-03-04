public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override string Drive(double distance)
    {
        string result = "Bus " + base.Drive(distance);
        return result;
    }

    public override string ToString()
    {
        return $"Bus: {FuelQuantity:f2}";
    }
}