using System;

class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();
        var a = int.Parse(Console.ReadLine());

        switch (figure)
        {
            case "Rectangle":
                var b = int.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(a, b);
                DrawingTool drawRectangle = new DrawingTool(rectangle);
                break;
            case "Square":
                Square square = new Square(a);
                DrawingTool drawingSquare = new DrawingTool(square);
                break;
        }
    }
}