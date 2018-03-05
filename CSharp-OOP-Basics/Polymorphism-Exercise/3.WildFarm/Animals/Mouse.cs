public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void ProduceSound()
    {
        System.Console.WriteLine("Squeak");
    }

    public override void Feed(Food food)
    {
        var foodType = food.GetType().ToString();
        if (foodType == "Vegetable" || foodType == "Fruit")
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.10;
        }
        else
        {
            base.Feed(food);
        }
    }

    public override string ToString()
    {
        return ("Mouse " + base.ToString());
    }
}