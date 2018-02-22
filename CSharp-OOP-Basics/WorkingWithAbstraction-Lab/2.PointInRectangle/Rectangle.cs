public class Rectangle
{
    private Point topLeft;

    public Point TopLeft
    {
        get { return topLeft; }
        set { topLeft = value; }
    }

    private Point bottomRight;

    public Point BottomRight
    {
        get { return bottomRight; }
        set { bottomRight = value; }
    }

    public Rectangle(Point top, Point bottom)
    {
        TopLeft = top;
        bottomRight = bottom;
    }

    public bool Contains(Point point)
    {
        bool isInside = bottomRight.X >= point.X && topLeft.X <= point.X
            && bottomRight.Y >= point.Y && topLeft.Y <= point.Y;
        return isInside;
    }
}
