using System;
using System.Collections.Generic;

public class ListyIterator<T>
{
    public ListyIterator(params T[] collection) 
    {
        this.List = new List<T>(collection);
        internalIndex = 0;
    }

    private List<T> List;
    private int internalIndex;

    public bool Move()
    {
        internalIndex++;

        if (internalIndex >= this.List.Count)
        {
            internalIndex--;
            return false;
        }

        return true;
    }

    public bool HasNext()
    {
        if (internalIndex == this.List.Count - 1)
            return false;

        return true;
    }

    public void Print()
    {
        if (this.List.Count == 0)
            throw new ArgumentException("Invalid Operation!");

        var element = this.List[internalIndex];
        Console.WriteLine(element);
    }
}