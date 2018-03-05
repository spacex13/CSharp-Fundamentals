public class Feline : Mammal
{
    public Feline(string name, double weight, string livingRegion, string breed)
        :base(name, weight, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed { get; set; }

    public override string ToString()
    {
        return $"[{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }

    public override void Feed(Food food)
    {
        base.Feed(food);
    }
}