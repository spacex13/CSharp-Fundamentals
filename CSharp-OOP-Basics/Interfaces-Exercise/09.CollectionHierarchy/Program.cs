using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        AddCollection addCollection = new AddCollection();
        AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
        MyList myList = new MyList();

        List<IAddCollection> addCollections = new List<IAddCollection>
        {
            addCollection,
            addRemoveCollection,
            myList
        };

        List<IAddRemoveCollection> removeCollections = new List<IAddRemoveCollection>
        {
            addRemoveCollection,
            myList
        };

        var line1 = Console.ReadLine().Split();

        foreach (var c in addCollections)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < line1.Length; i++)
            {
                var result = c.Add(line1[i]);
                output.Append(result + " ");
            }

            Console.WriteLine(output.ToString().Trim());
        }

        var line2 = int.Parse(Console.ReadLine());

        foreach (var c in removeCollections)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < line2; i++)
            {
                var result = c.Remove();
                output.Append(result + " ");
            }

            Console.WriteLine(output.ToString().Trim());
        }
    }
}