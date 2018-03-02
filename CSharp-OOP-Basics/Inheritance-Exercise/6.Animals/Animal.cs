using System;

public class Animal
{
    private string name;
    private int age;
    private string gender;
    private string animalType;

    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public virtual string AnimalType
    {
        get { return animalType; }
        set { animalType = value; }
    }


    public string Name
    {
        get { return name; }
        set
        {
            ValidateInput(value);
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            ValidateInput(value.ToString());
            if (value < 0)
            {
                throw  new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public string Gender
    {
        get { return gender; }
        set
        {
            ValidateInput(value);
            gender = value;
        }
    }

    protected void ValidateInput(string value)
    {
        if (String.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Invalid input!");
        }
    }

    public virtual void ProduceSound()
    {
        
    }
}

