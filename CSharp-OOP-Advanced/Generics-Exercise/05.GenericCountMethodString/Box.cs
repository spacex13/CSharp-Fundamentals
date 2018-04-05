using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
    where T : class, IComparable
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

    public int CountBiggerElements(T element)
    {
        var result = 0;

        foreach (var item in this.Data)
        {
            var str = item.CompareTo(element);
            switch(str)
            {
                case 1:
                    result += 1;
                    break;
                default:
                    break;
            }
        }

        return result;
    }
}