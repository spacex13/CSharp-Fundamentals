using System;

public class Pet : IBirthdate, IName
{
    public Pet(string name, DateTime birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    public string Name { get; set; }

    public DateTime Birthdate { get; set; }
}