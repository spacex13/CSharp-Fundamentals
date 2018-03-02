using System;

public class Kitten : Cat
{
    private string gender;

    public Kitten(string name, int age, string gender, string animalType) : base(name, age, gender, animalType)
    {
        Gender = "Female";
        AnimalType = animalType;
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }

}

