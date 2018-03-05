public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    public string Name { get; protected set; }

    public double Weight { get; protected set; }

    public int FoodEaten { get; set; }

    public abstract void ProduceSound();

    public virtual void Feed(Food food)
    {
        var foodType = food.GetType().ToString();
        System.Console.WriteLine($"{this.GetType().ToString()} does not eat {foodType}!");
    }
}