using System;

public class Citizen : IId, IBirthdate, IName
{
    public Citizen(string name, int age, string id, DateTime birhtdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birhtdate;
    }

    public string Name { get; private set; }

    public string Id { get; private set; }

    public int Age { get; private set; }

    public DateTime Birthdate { get; private set; }
}

