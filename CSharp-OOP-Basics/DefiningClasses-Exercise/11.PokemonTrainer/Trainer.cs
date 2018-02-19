using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int badges;
    public List<Pokemon> pokemons = new List<Pokemon>();

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Badges
    {
        get { return badges; }
    }

    public int AddBadge()
    {
        badges++;
        return badges;
    }

    public Trainer(string name, Pokemon pokemon)
    {
        this.name = name;
        pokemons.Add(pokemon);
    }
}
