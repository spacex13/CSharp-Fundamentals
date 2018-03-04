using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        List<ISoldier> soldiers = new List<ISoldier>();

        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            var info = line.Split();

            switch (info[0])
            {
                case "Private":
                    AddPrivate(info, soldiers);
                    break;
                case "LeutenantGeneral":
                    AddLeutenantGeneral(info, soldiers);
                    break;
                case "Engineer":
                    AddEngineer(info, soldiers);
                    break;
                case "Commando":
                    AddCommando(info, soldiers);
                    break;
                case "Spy":
                    AddSpy(info, soldiers);
                    break;
            }
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier);
        }
    }

    public static void AddPrivate(string[] info, List<ISoldier> soldiers)
    {
        var id = int.Parse(info[1]);
        var firstName = info[2];
        var lastName = info[3];
        double salary = double.Parse(info[4]);
        Private privateS = new Private(firstName, lastName, id, salary);
        soldiers.Add(privateS);
    }

    public static void AddLeutenantGeneral(string[] info, List<ISoldier> soldiers)
    {
        var id = int.Parse(info[1]);
        var firstName = info[2];
        var lastName = info[3];
        double salary = double.Parse(info[4]);
        List<ISoldier> privates = new List<ISoldier>();

        for (int i = 5; i < info.Length; i++)
        {
            ISoldier newPrivate = (ISoldier)soldiers.Find(p => p.Id == int.Parse(info[i]));
            privates.Add(newPrivate);
        }

        LeutenantGeneral leutenantGeneral = new LeutenantGeneral(firstName, lastName, id, salary, privates);
        soldiers.Add(leutenantGeneral);
    }

    public static void AddEngineer(string[] info, List<ISoldier> soldiers)
    {
        var id = int.Parse(info[1]);
        var firstName = info[2];
        var lastName = info[3];
        double salary = double.Parse(info[4]);
        string corps = info[5];
        List<Repair> repairs = new List<Repair>();

        if (corps == "Airforces" || corps == "Marines")
        {
            for (int i = 6; i < info.Length; i += 2)
            {
                Repair repair = new Repair(info[i], int.Parse(info[i + 1]));
                repairs.Add(repair);
            }

            Engineer engineer = new Engineer(firstName, lastName, id, salary, corps, repairs);
            soldiers.Add(engineer);
        }
    }

    public static void AddCommando(string[] info, List<ISoldier> soldiers)
    {
        var id = int.Parse(info[1]);
        var firstName = info[2];
        var lastName = info[3];
        double salary = double.Parse(info[4]);
        string corps = info[5];
        List<Mission> missions = new List<Mission>();

        if (corps == "Airforces" || corps == "Marines")
        {
            for (int i = 6; i < info.Length; i += 2)
            {
                var missionCodeName = info[i];
                var missionState = info[i + 1];

                if (missionState == "inProgress" || missionState == "Finished")
                {
                    Mission mission = new Mission(missionCodeName, missionState);
                    missions.Add(mission);
                }
            }

            Commando engineer = new Commando(firstName, lastName, id, salary, corps, missions);
            soldiers.Add(engineer);
        }
    }

    public static void AddSpy(string[] info, List<ISoldier> soldiers)
    {
        var id = int.Parse(info[1]);
        var firstName = info[2];
        var lastName = info[3];
        var codeNumber = int.Parse(info[4]);

        Spy spy = new Spy(firstName, lastName, id, codeNumber);
        soldiers.Add(spy);
    }
}

