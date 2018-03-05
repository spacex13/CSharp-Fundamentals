using System.Collections.Generic;

public class AddCollection : IAddCollection
{
    public AddCollection()
    {
        this.Collection = new List<string>();
    }
    public List<string> Collection { get; private set; }

    public virtual int Add(string item)
    {
        this.Collection.Add(item);

        return Collection.Count - 1;
    }
}