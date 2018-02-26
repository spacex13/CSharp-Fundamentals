using System;
using System.Collections.Generic;

public class RandomList : List<string>
{
    Random radnom = new Random();

    public string RandomString(List<string> data)
    {
        int index = radnom.Next(0, data.Count - 1);
        string str = data[index];
        data.RemoveAt(index);
        return str;
    }

}
