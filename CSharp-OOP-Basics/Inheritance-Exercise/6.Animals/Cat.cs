using System;

public class Cat : Animal
{
    public Cat(string name, int age, string gender, string animalType) : base(name, age, gender)
    {
        AnimalType = animalType;
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow meow");
    }
}

