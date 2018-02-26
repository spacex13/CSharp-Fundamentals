using System;

public class Stats
{
    private const int MIN_VALUE = 0;
    private const int MAX_VALUE = 100;

    private int  endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public double StatsAverage => (endurance + sprint + dribble + passing + shooting) / 5.0;

    public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }

    public int  Endurance
    {
        get { return endurance; }
        set
        {
            ValidateStats(value, "Endurance");
            endurance = value;
        }
    }

    public int Sprint
    {
        get { return sprint; }
        set
        {
            ValidateStats(value, "Sprint");
            sprint = value;
        }
    }

    public int Dribble
    {
        get { return dribble; }
        set
        {
            ValidateStats(value, "Dribble");
            dribble = value;
        }
    }

    public int Passing
    {
        get { return passing; }
        set
        {
            ValidateStats(value, "Passing");
            passing = value;
        }
    }

    public int Shooting
    {
        get { return shooting; }
        set
        {
            ValidateStats(value, "Shooting");
            shooting = value;
        }
    }

    private static void ValidateStats(int value, string stat)
    {
        if (value < MIN_VALUE || value > MAX_VALUE)
        {
            throw new ArgumentException($"{stat} should be between {MIN_VALUE} and {MAX_VALUE}.");
        }
    }
}

