public class CymricCat : Cat
{
    public CymricCat(string name, double furLength) 
        : base (name)
    {
        this.FurLength = furLength;
    }

    public double FurLength { get; private set; }

    public override string ToString()
    {
        return base.ToString() + $"{this.FurLength:f2}";
    }
}