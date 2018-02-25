using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private double money;
    private List<Product> products = new List<Product>();

    public string Name
    {
        get { return name; }
        set
        {
            if (value == "" || value == " ")
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    public double Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }
    }

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }

    public Person(string name, double money)
    {
        this.Name = name;
        this.Money = money;
    }

    public void BuyProduct(Product product)
    {
        if (product.Cost > this.Money)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
        else
        {
            Products.Add(product);
            Money -= product.Cost;
            Console.WriteLine($"{Name} bought {product.Name}");
        }
    }

    public override string ToString()
    {

        return $"{Name} - {string.Join(", ", Products.Select(p => p.Name))}";
    }
}

