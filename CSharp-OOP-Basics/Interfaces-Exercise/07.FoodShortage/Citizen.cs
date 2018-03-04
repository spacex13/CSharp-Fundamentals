using System;

public class Citizen : IId, IBirthdate, IBuyer
{
    public Citizen(string name, int age, string id, DateTime birhtdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birhtdate;
        this.Food = 0;
    }

    public string Name { get; private set; }

    public string Id { get; private set; }

    public int Age { get; private set; }

    public DateTime Birthdate { get; private set; }

    public int Food { get; private set; }

    public void BuyFood()
    {
        Food += 10;
    }
}

