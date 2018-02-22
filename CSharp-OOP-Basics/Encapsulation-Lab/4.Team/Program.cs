using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var team = new Team("team");

        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            try
            {
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                team.AddPlayer(person);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reverse team has {team.ReserveTeam.Count} players.");
    }
}

