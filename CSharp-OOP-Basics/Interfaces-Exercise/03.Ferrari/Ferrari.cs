public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Driver { get; private set; }

    public string Model => "488-Spider";

    public string Brakes()
    {
        return "Brakes!";
    }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.Driver}";
    }
}

