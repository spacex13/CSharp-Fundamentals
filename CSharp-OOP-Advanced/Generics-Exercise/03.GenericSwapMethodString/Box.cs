using System.Collections.Generic;
using System.Text;

public class Box<T>
    where T : class
{
    public Box()
    {
        this.Data = new List<T>();
    }

    public List<T> Data { get; }

    public void Add(T element)
    {
        this.Data.Add(element);
    }

    public void Swap(int[] swapIndexes)
    {
        int index1 = swapIndexes[0];
        int index2 = swapIndexes[1];

        var temp = this.Data[index1];
        this.Data[index1] = this.Data[index2];
        this.Data[index2] = temp;
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();

        foreach (var item in this.Data)
        {
            var type = item.GetType().FullName;

            str.AppendLine($"{type}: {item}");
        }

        return str.ToString();
    }
}