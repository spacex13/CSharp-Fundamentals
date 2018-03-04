using System;
using System.Collections.Generic;
using System.Globalization;

public class Program
{
    static void Main()
    {
        List<IBirthdate> birthdates = new List<IBirthdate>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var info = command.Split();

            switch (info[0])
            {
                case "Citizen":
                    AddCitizen(info, birthdates);
                    break;
                case "Pet":
                    AddPet(info, birthdates);
                    break;
                case "Robot":
                    Robot robot = new Robot(info[1], info[2]);
                    break;
            }
        }

        int year = int.Parse(Console.ReadLine());

        foreach (var date in birthdates)
        {
            if (date.Birthdate.Year == year)
            {
                Console.WriteLine("{0:dd'/'MM'/'yyyy}", date.Birthdate);
            }
        }
    }

    public static void AddCitizen(string[] info, List<IBirthdate> birthdates)
    {
        var name = info[1];
        var age = int.Parse(info[2]);
        var id = info[3];
        DateTime birthdate = DateTime.ParseExact(info[4], "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
        Citizen citizen = new Citizen(name, age, id, birthdate);
        birthdates.Add(citizen);
    }

    public static void AddPet(string[] info, List<IBirthdate> birthdates)
    {
        var name = info[1];
        DateTime birthdate = DateTime.ParseExact(info[2], "dd/MM/yyyy", new DateTimeFormatInfo());
        Pet pet = new Pet(name, birthdate);
        birthdates.Add(pet);
    }
}