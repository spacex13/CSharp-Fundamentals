using System;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T>
    where T : IComparable
{
    public CustomList()
    {
        this.Data = new List<T>();
    }

    public List<T> Data { get; }

    public void Add(T element)
    {
        this.Data.Add(element);
    }

    public T Remove(int index)
    {
        var result = this.Data[index];
        this.Data.RemoveAt(index);

        return result;
    }

    public bool Contains(T element)
    {
        if (this.Data.Any(e => e.CompareTo(element) == 0))
            return true;

        return false;
    }

    public void Swap(int index1, int index2)
    {
        var temp = this.Data[index1];
        this.Data[index1] = this.Data[index2];
        this.Data[index2] = temp;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;

        foreach (var item in this.Data)
        {
            if (item.CompareTo(element) == 1)
                count++;
        }

        return count;
    }

    public T Max()
    {
        var max = this.Data.Max();

        return max;
    }

    public T Min()
    {
        var min = this.Data.Min();

        return min;
    }

    public override string ToString()
    {
        var result = string.Join(Environment.NewLine, this.Data);

        return result;
    }

    internal void OrderBy()
    {
        this.Data.Sort();
    }
}