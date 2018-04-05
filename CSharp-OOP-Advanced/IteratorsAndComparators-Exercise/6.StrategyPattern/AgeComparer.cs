using System.Collections.Generic;

public class AgeComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Age - y.Age;

        return result;
    }
}