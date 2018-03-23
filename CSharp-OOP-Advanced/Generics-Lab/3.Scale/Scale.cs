using System;

public class Scale<T>
    where T: IComparable<T>
{
    public Scale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }

    private T left;
    private T right;

    public T GetHeavier()
    {
        var result = this.left.CompareTo(this.right);

        switch(result)
        {
            case 1:
                return this.left;
            case -1:
                return this.right;
            default:
                return default(T);
        }
    }
}