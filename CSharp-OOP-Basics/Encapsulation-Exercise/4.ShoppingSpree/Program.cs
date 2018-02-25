using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string pattern = @"([\w]*)=([+-]*[\d]+)";
            Regex regex = new Regex(pattern);

            MatchCollection peopleInfo = regex.Matches(line1);
            MatchCollection productsInfo = regex.Matches(line2);

            try
            {
                foreach (Match p in peopleInfo)
                {

                    var name = p.Groups[1].Value;
                    var money = int.Parse(p.Groups[2].Value);
                    Person person = new Person(name, money);
                    people.Add(person);

                }

                foreach (Match p in productsInfo)
                {
                    var name = p.Groups[1].Value;
                    var cost = int.Parse(p.Groups[2].Value);
                    Product product = new Product(name, cost);
                    products.Add(product);
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var line = command.Split();
                    var name = line[0];
                    Product pr = products.First(p => p.Name == line[1]);
                    people.First(p => p.Name == name).BuyProduct(pr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            
            foreach (var person in people)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}
