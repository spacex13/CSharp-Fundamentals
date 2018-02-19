public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double x;
    private double y;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public double X1
    {
        get { return this.x + this.width; }
    }

    public double Y1
    {
        get { return this.y + this.height; }
    }

    public Rectangle(string id, double width, double height, double x, double y)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.X = x;
        this.Y = y;
    }

    public bool Intersect(Rectangle r2)
    {
        // If one rectangle is on left side of other
        if (X > r2.X1 ||
            r2.X > X1)
            return false;

        // If one rectangle is above other
        if (Y > r2.Y1 ||
            r2.Y > Y1)
            return false;

        return true;
    }
}