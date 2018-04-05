public class Tuple<item1, item2>
{
    public Tuple(item1 first, item2 second)
    {
        this.FirstItem = first;
        this.SecondItem = second;
    }

    public item1 FirstItem { get; }

    public item2 SecondItem { get; }

    public override string ToString()
    {
        return $"{this.FirstItem} -> {this.SecondItem}";
    }
}