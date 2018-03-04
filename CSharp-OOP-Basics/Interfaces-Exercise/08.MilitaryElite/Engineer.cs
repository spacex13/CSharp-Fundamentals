using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string firstName, string lastName, int id, double salary, string corps, List<Repair> repairs)
        :base(firstName, lastName, id, salary, corps)
    {
        this.Repairs = repairs;
    }

    public List<Repair> Repairs { get; private set; }

    public string PrintRepairs()
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < Repairs.Count; i++)
        {
            if (i == Repairs.Count - 1)
            {
                str.Append("\n  " + Repairs[i].ToString());
            }
            else
            {
                str.Append("\n  " + Repairs[i].ToString());
            }
        }

        return str.ToString();
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nRepairs:{PrintRepairs()}";
    }
}