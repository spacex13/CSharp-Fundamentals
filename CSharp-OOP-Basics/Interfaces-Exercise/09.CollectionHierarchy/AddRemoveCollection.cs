public class AddRemoveCollection : AddCollection, IAddRemoveCollection
{
    public override int Add(string item)
    {
        this.Collection.Insert(0, item);
        return 0;
    }

    public virtual string Remove()
    {
        var removeIndex = Collection.Count - 1;
        var removedItem = this.Collection[removeIndex];

        this.Collection.RemoveAt(removeIndex);
        return removedItem;
    }
}