using System;

public class Frog :Animal
{
    public Frog(string name, int age, string gender, string animalType) : base(name, age, gender)
    {
        AnimalType = animalType;
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Ribbit");
    }
}

