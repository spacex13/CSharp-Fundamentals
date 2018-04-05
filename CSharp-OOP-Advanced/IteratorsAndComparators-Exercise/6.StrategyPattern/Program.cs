using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<Person> set1 = new SortedSet<Person>(new NameLengthComparer());
        SortedSet<Person> set2 = new SortedSet<Person>(new AgeComparer());

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split();
            Person person = new Person(line[0], int.Parse(line[1]));
            set1.Add(person);
            set2.Add(person);
        }

        foreach (var person in set1)
        {
            Console.WriteLine(person);
        }

        foreach (var person in set2)
        {
            Console.WriteLine(person);
        }
    }
}