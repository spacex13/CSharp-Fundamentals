using System.Collections.Generic;

public class Box<T>
{
    Stack<T> box = new Stack<T>();

    public void Add(T element)
    {
        this.box.Push(element);
    }

    public T Remove()
    {
        return this.box.Pop();
    }

    public int Count { get => this.box.Count; }
}