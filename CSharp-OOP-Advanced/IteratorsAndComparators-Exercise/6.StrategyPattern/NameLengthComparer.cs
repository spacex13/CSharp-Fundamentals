using System.Collections.Generic;

public class NameLengthComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length - y.Name.Length;

        if (result == 0)
        {
            var xName = x.Name.ToLower();
            var yName = y.Name.ToLower();
            char first = xName[0];
            char second = yName[0];

            result = first - second;
        }

        return result;
    }
}