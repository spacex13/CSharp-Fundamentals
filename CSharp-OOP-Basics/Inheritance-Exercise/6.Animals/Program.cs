using System;
using System.Collections.Generic;

namespace _6.Animals
{
    class Program
    {
        static void Main()
        {
            string command;
            List<Animal> animals = new List<Animal>();

            while ((command = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    AddAnimal(command, animals);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.AnimalType);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                animal.ProduceSound();
            }

        }

        static void AddAnimal(string command, List<Animal> animals)
        {
            var animalType = command;
            var info = Console.ReadLine().Split();
            var name = info[0];
            var age = int.Parse(info[1]);
            var gender = info[2];

            switch (animalType)
            {
                case "Cat":
                    Cat cat = new Cat(name, age, gender, animalType);
                    animals.Add(cat);
                    break;
                case "Dog":
                    Dog dog = new Dog(name, age, gender, animalType);
                    animals.Add(dog);
                    break;
                case "Frog":
                    Frog frog = new Frog(name, age, gender, animalType);
                    animals.Add(frog);
                    break;
                case "Kitten":
                    Kitten kitten = new Kitten(name, age, gender, animalType);
                    animals.Add(kitten);
                    break;
                case "Tomcat":
                    Tomcat tomcat = new Tomcat(name, age, gender, animalType);
                    animals.Add(tomcat);
                    break;
                    default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
