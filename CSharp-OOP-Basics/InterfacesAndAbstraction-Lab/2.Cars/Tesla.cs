using System.Text;

public class Tesla : IElectricCar, ICar
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Batteries { get; set; }

    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Batteries = batteries;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();

        str.AppendLine($"{Color} Tesla {Model} with {Batteries} Batteries")
            .AppendLine(Start())
            .Append(Stop());
        return str.ToString();
    }
}
