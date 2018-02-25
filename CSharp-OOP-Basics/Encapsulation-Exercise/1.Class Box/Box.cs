﻿public class Box
{
    private double length { get; set; }
    private double width { get; set; }
    private double height { get; set; }

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double SurfaceArea()
    {
        return 2 * (length * width + length * height + width * height);
    }

    public double LateralSurfaceArea()
    {
        return 2 * (length * height + width * height);
    }

    public double Volume()
    {
        return length * width * height;
    }
}

