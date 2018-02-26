using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private List<Player> players;
    private string teamName;
    private double rating;

    public List<Player> Players
    {
        get { return players; }
        private set { players = value; }
    }

    public Team(string name)
    {
        TeamName = name;
        Players = new List<Player>();
    }

    public string TeamName
    {
        get { return teamName; }
        set
        {
            if (value == null || value == "" || value == " ")
            {
                throw new ArgumentException("A name should not be empty.");
            }
            teamName = value;
        }
    }

    public double Rating
    {
        get { return rating; }
        set { rating = value; }
    }

    public void RemovePlayer(string player)
    {
        if (!players.Any(p => p.Name == player))
        {
            throw new ArgumentException($"Player {player} is not in {TeamName} team.");
        }

        Player playerToRemove = players.First(p => p.Name == player);
        Players.Remove(playerToRemove);
    }

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public double CalculateRating()
    {
        if (players.Count == 0)
            return 0;
        double rating = players.Average(p => p.PlayerAverageStats);
        return rating;
    }

    public override string ToString()
    {
        return $"{TeamName} - {Math.Round(CalculateRating())}";
    }
}

