public class Cat
{
    public Cat()
    {

    }

    public Cat(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }

    public override string ToString()
    {
        var type = this.GetType().ToString();
        var index = type.IndexOf("Cat");
        var typeCat = type.Remove(index);

        return $"{typeCat} {this.Name} ";
    }
}