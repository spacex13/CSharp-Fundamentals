using System;

public class Tomcat : Cat
{

    public Tomcat(string name, int age, string gender, string animalType) : base(name, age, gender, animalType)
    {
        this.Gender = "Male";
    }

    public override void ProduceSound()
    {
        Console.WriteLine("MEOW");
    }
}

