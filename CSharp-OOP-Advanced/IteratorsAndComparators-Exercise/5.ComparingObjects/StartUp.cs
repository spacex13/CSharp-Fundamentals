using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        string commandArgs;
        while ((commandArgs = Console.ReadLine()) != "END")
        {
            var commandInfo = commandArgs.Split().ToArray();
            var name = commandInfo[0];
            var age = int.Parse(commandInfo[1]);
            var town = commandInfo[2];

            Person person = new Person(name, age, town);
            people.Add(person);
        }

        var n = int.Parse(Console.ReadLine()) - 1;

        var thePerson = people[n];

        var equal = people.Where(p => thePerson.CompareTo(p) == 0).Count();

        if (equal == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            var notEqual = people.Count - equal;
            Console.WriteLine($"{equal} {notEqual} {people.Count}");
        }
    }
}