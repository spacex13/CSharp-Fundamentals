using System;

namespace _3.HierarchicalInheritance
{
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
