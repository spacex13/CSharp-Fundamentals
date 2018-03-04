public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption)
        :base(fuelQuantity, fuelConsumption)
    {
        this.FuelConsumption += 0.9;
    }

    public override string Drive(double distance)
    {
        string result = "Car " + base.Drive(distance);
        return result;
    }

    public override string ToString()
    {
        return $"Car: {FuelQuantity:f2}";
    }
}