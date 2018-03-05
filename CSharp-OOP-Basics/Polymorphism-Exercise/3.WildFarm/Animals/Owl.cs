public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    public override void ProduceSound()
    {
        System.Console.WriteLine("Hoot Hoot");
    }

    public override void Feed(Food food)
    {
        var foodType = food.GetType().ToString();
        if (foodType == "Meat")
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.25;
        }
        else
        {
            base.Feed(food);
        }
    }

    public override string ToString()
    {
        return ("Owl " + base.ToString());
    }
}