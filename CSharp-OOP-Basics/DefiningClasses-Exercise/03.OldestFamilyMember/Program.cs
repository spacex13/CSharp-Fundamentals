using System;

namespace _03.OldestFamilyMember
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
