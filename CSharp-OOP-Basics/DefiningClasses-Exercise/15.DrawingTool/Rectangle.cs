public class Rectangle : Square
{
    public Rectangle(int a, int b)
        :base(a)
    {
        this.B = b;
    }

    public int B { get; private set; }

    public override void Draw()
    {
        for (int i = 1; i <= this.B; i++)
        {
            System.Console.Write("|");

            for (int p = 1; p <= this.A; p++)
            {
                if (i == 1 || i == this.B)
                {
                    System.Console.Write("-");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }

            System.Console.Write("|");
            System.Console.WriteLine();
        }
    }
}