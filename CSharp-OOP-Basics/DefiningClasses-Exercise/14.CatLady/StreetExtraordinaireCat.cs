public class StreetExtraordinaireCat : Cat
{
    public StreetExtraordinaireCat(string name, double decibelOfMeows)
        : base(name)
    {
        this.DecibelOfMeows = decibelOfMeows;
    }

    public double DecibelOfMeows { get; private set; }

    public override string ToString()
    {
        return base.ToString() + $"{this.DecibelOfMeows}";
    }
}