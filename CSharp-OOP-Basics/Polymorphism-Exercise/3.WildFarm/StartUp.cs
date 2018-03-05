using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();

        string line;

        while ((line = Console.ReadLine()) != "End")
        {
            var info = line.Split();
            var type = info[0];
            var name = info[1];
            var weight = double.Parse(info[2]);

            switch (type)
            {
                case "Owl":
                    var wingSize = double.Parse(info[3]);
                    Owl owl = new Owl(name, weight, wingSize);
                    animals.Add(owl);
                    Eat(owl);
                    break;
                case "Hen":
                    wingSize = double.Parse(info[3]);
                    Hen hen = new Hen(name, weight, wingSize);
                    animals.Add(hen);
                    Eat(hen);
                    break;
                case "Mouse":
                    var livingRegion = info[3];
                    Mouse mouse = new Mouse(name, weight, livingRegion);
                    animals.Add(mouse);
                    Eat(mouse);
                    break;
                case "Dog":
                    livingRegion = info[3];
                    Dog dog = new Dog(name, weight, livingRegion);
                    animals.Add(dog);
                    Eat(dog);
                    break;
                case "Cat":
                    livingRegion = info[3];
                    var breed = info[4];
                    Cat cat = new Cat(name, weight, livingRegion, breed);
                    animals.Add(cat);
                    Eat(cat);
                    break;
                case "Tiger":
                    livingRegion = info[3];
                    breed = info[4];
                    Tiger tiger = new Tiger(name, weight, livingRegion, breed);
                    animals.Add(tiger);
                    Eat(tiger);
                    break;
            }
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }

    public static void Eat(Animal animal)
    {
        var line = Console.ReadLine();

        var foodInfo = line.Split();
        var foodType = foodInfo[0];
        var quantity = int.Parse(foodInfo[1]);

        switch (foodType)
        {
            case "Meat":
                Meat meat = new Meat(quantity);
                animal.ProduceSound();
                animal.Feed(meat);
                break;
            case "Vegetable":
                Vegetable veggie = new Vegetable(quantity);
                animal.ProduceSound();
                animal.Feed(veggie);
                break;
            case "Fruit":
                Fruit fruit = new Fruit(quantity);
                animal.ProduceSound();
                animal.Feed(fruit);
                break;
            case "Seeds":
                Seeds seeds = new Seeds(quantity);
                animal.ProduceSound();
                animal.Feed(seeds);
                break;
        }
    }
}