public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    public SpecialisedSoldier(string firstName, string lastName, int id, double salary, string corps)
        :base(firstName, lastName, id, salary)
    {
        this.Corps = corps;
    }

    public string Corps { get; private set; }

    public override string ToString()
    {
        return base.ToString() + $"\nCorps: {this.Corps}";
    }
}
