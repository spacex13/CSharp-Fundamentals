public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
    }

    public override void ProduceSound()
    {
        System.Console.WriteLine("ROAR!!!");
    }

    public override void Feed(Food food)
    {
        var foodType = food.GetType().ToString();
        if (foodType == "Meat")
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 1.00;
        }
        else
        {
            base.Feed(food);
        }
    }

    public override string ToString()
    {
        return ("Tiger " + base.ToString());
    }
}