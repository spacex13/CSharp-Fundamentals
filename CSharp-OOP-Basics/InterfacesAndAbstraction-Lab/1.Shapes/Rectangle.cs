using System;

public class Rectangle : IDrawable
{
    public int Width { get; private set; }
    public int Height { get; private set; }

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public void Draw()
    {
        DrawLine(this.Width, '*','*');
        for (int i = 1; i < this.Height - 1; i++)
        {
            DrawLine(this.Width, ' ', '*');
        }
        DrawLine(this.Width, '*', '*');
    }

    public void DrawLine(int width, char mid, char end)
    {
        Console.Write(end);
        for (int i = 1; i < width - 1; i++)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }
}

