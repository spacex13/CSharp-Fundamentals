using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<Person> sortedSet = new SortedSet<Person>();
        HashSet<Person> hashSet = new HashSet<Person>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split();
            Person person = new Person(line[0], int.Parse(line[1]));
            hashSet.Add(person);
            sortedSet.Add(person);
        }

        Console.WriteLine(sortedSet.Count);
        Console.WriteLine(hashSet.Count);
    }
}