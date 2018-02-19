using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OpinionPoll
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            var over30 = people.Where(x => x.Age > 30).OrderBy(x => x.Name);

            foreach (var person in over30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
