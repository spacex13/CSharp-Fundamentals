public class SiameseCat : Cat
{
    public SiameseCat(string name, double earSize)
        : base (name)
    {
        this.EarSize = earSize;
    }

    public double EarSize { get; private set; }

    public override string ToString()
    {
        return base.ToString() + $"{this.EarSize}";
    }
}