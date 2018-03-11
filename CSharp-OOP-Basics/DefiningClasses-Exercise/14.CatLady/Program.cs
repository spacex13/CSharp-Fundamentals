using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.CatLady
{
    class Program
    {
        static void Main()
        {
            string line;

            List<Cat> cats = new List<Cat>();

            while((line =Console.ReadLine()) != "End")
            {
                var info = line.Split();
                var type = info[0];
                var name = info[1];
                Cat cat = new Cat();

                switch(type)
                {
                    case "Siamese":
                        var earSize = double.Parse(info[2]);
                        cat = new SiameseCat(name, earSize);
                        break;
                    case "Cymric":
                        var furLength = double.Parse(info[2]);
                        cat = new CymricCat(name, furLength);
                        break;
                    case "StreetExtraordinaire":
                        var decibelOfMeows = double.Parse(info[2]);
                        cat = new StreetExtraordinaireCat(name, decibelOfMeows);
                        break;
                }

                cats.Add(cat);
            }

            var nameToPrint = Console.ReadLine();
            Cat catToPrint = cats.First(c => c.Name == nameToPrint);
            Console.WriteLine(catToPrint);
        }
    }
}
