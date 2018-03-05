public class Bird : Animal
{
    public Bird(string name, double weight,double wingSize) 
        :base(name, weight)
    {
        this.WingSize = wingSize;
    }

    public double WingSize { get; protected set; }

    public override void ProduceSound()
    {
    }

    public override void Feed(Food food)
    {
        base.Feed(food);
    }

    public override string ToString()
    {
        return $"[{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}