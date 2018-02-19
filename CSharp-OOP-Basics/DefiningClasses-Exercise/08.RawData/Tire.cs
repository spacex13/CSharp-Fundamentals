public class Tire
{
    private int tireAge;
    private double tirePressure;

    public int TireAge
    {
        get { return tireAge; }
        set { tireAge = value; }
    }

    public double TirePressure
    {
        get { return tirePressure; }
        set { tirePressure = value; }
    }

    public Tire (int tireAge, double tirePressure)
    {
        this.TireAge = tireAge;
        this.TirePressure = tirePressure;
    }
}

