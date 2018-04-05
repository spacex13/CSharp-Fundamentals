public class Threeuple<item1, item2, item3>
{
    public Threeuple(item1 first, item2 second, item3 third)
    {
        this.FirstItem = first;
        this.SecondItem = second;
        this.ThirdItem = third;
    }

    public item1 FirstItem { get; set; }

    public item2 SecondItem { get; set; }

    public item3 ThirdItem { get; set; }

    public override string ToString()
    {
        return $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirdItem}";
    }
}