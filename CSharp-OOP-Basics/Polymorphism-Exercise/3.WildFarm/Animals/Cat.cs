public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed)
    : base(name, weight, livingRegion, breed)
    {
    }

    public override void ProduceSound()
    {
        System.Console.WriteLine("Meow");
    }

    public override void Feed(Food food)
    {
        var foodType = food.GetType().ToString();
        if (foodType == "Vegetable" || foodType == "Meat")
        {
            this.Weight += food.Quantity * 0.30;
            this.FoodEaten += food.Quantity;
        }
        else
        {
            base.Feed(food);
        }
    }

    public override string ToString()
    {
        return ("Cat " + base.ToString());
    }
}