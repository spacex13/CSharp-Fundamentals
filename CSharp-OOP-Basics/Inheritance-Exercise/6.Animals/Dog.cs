using System;

public class Dog : Animal
{
    public Dog(string name, int age, string gender, string animalType) : base(name, age, gender)
    {
        AnimalType = animalType;
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Woof!");
    }
}

