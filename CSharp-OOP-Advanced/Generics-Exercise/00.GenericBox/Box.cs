using System.Collections.Generic;

public class Box<T>
{
    public Box(T element)
    {
        this.Data = element;
    }

    public T Data { get; }

    public override string ToString()
    {
        var type = this.Data.GetType().FullName;
        return $"{type}: {this.Data.ToString()}";
    }
}