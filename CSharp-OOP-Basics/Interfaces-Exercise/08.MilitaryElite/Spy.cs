public class Spy : Soldier,  ISoldier, ISpy
{
    public Spy(string firstName, string lastName, int id, int codeNumber) : base (firstName, lastName, id)
    {
        this.CodeNumber = codeNumber;
    }

    public int CodeNumber { get; private set; }

    public override string ToString()
    {
        return base.ToString() + 
            $"\nCode Number: {CodeNumber}";
    }
}