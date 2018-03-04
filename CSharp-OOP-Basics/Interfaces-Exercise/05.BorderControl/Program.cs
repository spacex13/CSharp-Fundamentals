using System;
using System.Collections.Generic;

namespace _05.BorderControl
{
    class Program
    {
        static void Main()
        {
            List<IId> ids = new List<IId>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var info = command.Split();

                if (info.Length == 3)
                {
                    Citizen citizen = new Citizen(info[0], int.Parse(info[1]), info[2]);
                    ids.Add(citizen);
                }
                else
                {
                    Robot robot = new Robot(info[0], info[1]);
                    ids.Add(robot);
                }
            }

            string end = Console.ReadLine();

            foreach (var id in ids)
            {
                if (id.Id.EndsWith(end))
                {
                    Console.WriteLine(id.Id);
                }
            }
        }
    }
}
