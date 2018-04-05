using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    public Stack()
    {
        this.list = new List<T>();
    }

    private List<T> list;

    public void Push(params T[] elements)
    {
        foreach (var element in elements)
        {
            this.list.Add(element);
        }
    }

    public T Pop()
    {
        if (this.list.Count == 0)
            throw new System.Exception("No elements");

        var lastIndex = this.list.Count - 1;
        var result = this.list[lastIndex];
        this.list.RemoveAt(lastIndex);

        return result;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.list.Count - 1; i >= 0; i--)
        {
            yield return this.list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = this.list.Count - 1; i >= 0; i--)
        {
            yield return this.list[i];
        }
    }
}