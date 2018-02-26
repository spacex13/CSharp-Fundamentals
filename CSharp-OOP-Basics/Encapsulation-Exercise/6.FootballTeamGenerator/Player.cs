using System;

public class Player
{
    private string name;
    private Stats stats;

    public string Name
    {
        get { return name; }
        set
        {
            if (value == null || value == "" || value == " ")
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }

    public Stats Stats
    {
        get { return stats; }
        set { stats = value; }
    }

    public Player(string name, Stats stats)
    {
        Name = name;
        Stats = stats;
    }

    public double PlayerAverageStats => Stats.StatsAverage;
}

