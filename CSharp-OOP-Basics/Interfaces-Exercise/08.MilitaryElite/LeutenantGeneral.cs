using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string firstName, string lastName, int id, double salary, List<ISoldier> privates)
        :base(firstName, lastName, id, salary)
    {
        this.Privates = privates;
    }

    public List<ISoldier> Privates { get; }

    public string PrintPrivates()
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < Privates.Count; i++)
        {
            if (i == Privates.Count - 1)
            {
                str.Append("\n  " + Privates[i].ToString());
            }
            else
            {
                str.Append("\n  " + Privates[i].ToString());
            }
        }

        return str.ToString();
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nPrivates:{PrintPrivates()}";
    }
}
