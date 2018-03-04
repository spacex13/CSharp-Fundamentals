using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string firstName, string lastName, int id, double salary, string corps, List<Mission> missions)
        :base(firstName, lastName, id, salary, corps)
    {
        this.Missions = missions;
    }

    public List<Mission> Missions { get; private set; }

    public string PrintMissions()
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < Missions.Count; i++)
        {
            if (i == Missions.Count - 1)
            {
                str.Append("\n  " + Missions[i].ToString());
            }
            else
            {
                str.Append("\n  " + Missions[i].ToString());
            }
        }

        return str.ToString();
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nMissions:{PrintMissions()}";
    }
}