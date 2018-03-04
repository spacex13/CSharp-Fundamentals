public class Private : Soldier, IPrivate
{
    public Private(string firstName, string lastName, int id, double salary)
        :base(firstName, lastName, id)
    {
        this.Salary = salary;
    }

    public double Salary { get; private set; }

    public override string ToString()
    {
        return base.ToString() + $" Salary: {Salary:f2}";
    }
}

