public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void ProduceSound()
    {
        System.Console.WriteLine("Woof!");
    }

    public override void Feed(Food food)
    {
        var foodType = food.GetType().ToString();
        if (foodType == "Meat")
        {
            this.Weight += food.Quantity * 0.40;
        }
        else
        {
            base.Feed(food);
        }
    }

    public override string ToString()
    {
        return ("Dog " + base.ToString());
    }
}