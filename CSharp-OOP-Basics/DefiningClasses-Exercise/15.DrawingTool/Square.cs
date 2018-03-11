public class Square
{
    public Square(int a)
    {
        this.A = a;
    }

    public int A { get; private set; }

    public virtual void Draw()
    {
        for (int i = 1; i <= this.A; i++)
        {
            System.Console.Write("|");

            for (int p = 1; p <= this.A; p++)
            {
                if (i == 1 || i == this.A)
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