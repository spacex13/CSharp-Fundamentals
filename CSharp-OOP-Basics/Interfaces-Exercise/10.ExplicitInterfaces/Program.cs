using System;

class Program
{
    static void Main()
    {
        string line;
        while((line = Console.ReadLine()) != "End")
        {
            var info = line.Split();
            var name = info[0];
            var country = info[1];
            var age = int.Parse(info[2]);

            Citizen citizen = new Citizen(name, country, age);
            Console.WriteLine(((IPerson)citizen).GetName());
            Console.WriteLine(((IResident)citizen).GetName());
        }
    }
}