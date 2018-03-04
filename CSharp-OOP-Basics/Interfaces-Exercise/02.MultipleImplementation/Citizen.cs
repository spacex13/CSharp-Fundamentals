﻿public class Citizen : IPerson, IBirthable, IIdentifiable
{
    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Citizen(string name, int age, string id, string birthdate)
        : this(name, age)
    {
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Birthdate { get; set; }

    public string Id { get; set; }
}
