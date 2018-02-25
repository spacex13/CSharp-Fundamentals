using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

            string command;
            while ((command = Console.ReadLine()) != "Output")
            {
                string[] commandInfo = command.Split();
                var departament = commandInfo[0];
                var firstName = commandInfo[1];
                var lastName = commandInfo[2];
                var patient = commandInfo[3];
                var fullName = firstName + lastName;

                if (!doctors.ContainsKey(firstName + lastName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool enoughRoom = departments[departament].SelectMany(x => x).Count() < 60;
                if (enoughRoom)
                {
                    int room = 0;
                    doctors[fullName].Add(patient);
                    for (int r = 0; r < departments[departament].Count; r++)
                    {
                        if (departments[departament][r].Count < 3)
                        {
                            room = r;
                            break;
                        }
                    }

                    departments[departament][room].Add(patient);
                }
            }

            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]][room - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
                }
            }
        }
    }
}
