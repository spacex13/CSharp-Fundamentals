public class Mammal : Animal
{
    public Mammal(string name, double weight, string livingRegion)
        : base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion { get; protected set; }

    public override void ProduceSound()
    {
    }

    public override void Feed(Food food)
    {
        base.Feed(food);
    }

    public override string ToString()
    {
        return $"[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}