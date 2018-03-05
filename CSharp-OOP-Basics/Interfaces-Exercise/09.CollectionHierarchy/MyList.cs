public class MyList : AddRemoveCollection, IMyList
{
    public int Used => this.Collection.Count;

    public override string Remove()
    {
        var removedItem = Collection[0];
        this.Collection.RemoveAt(0);
        return removedItem;
    }
}