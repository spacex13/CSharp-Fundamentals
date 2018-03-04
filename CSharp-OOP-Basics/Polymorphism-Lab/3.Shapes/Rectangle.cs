public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Height { get; private set; }

    public double Width { get; private set; }


    public override double CalculatePerimeter()
    {
        var perimeter = 2* (this.Height + this.Width);
        return perimeter;
    }

    public override double CalculateArea()
    {
        var area = this.Height * this.Width;
        return area;
    }

    public override string Draw()
    {
        return (base.Draw() + " Rectangle");
    }
}