using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.FootballTeamGenerator
{
    class Program
    {
        static void Main()
        {
            string command;
            List<Team> teams = new List<Team>();

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    var line = command.Split(";");
                    switch (line[0])
                    {
                        case "Team":
                            string teamName = line[1];
                            Team team = new Team(teamName);
                            teams.Add(team);
                            break;
                        case "Add":
                            AddPlayer(line, teams);
                            break;
                        case "Remove":
                            RemovePlayer(line, teams);
                            break;
                        case "Rating":
                            Raing(line, teams);
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void Raing(string[] line, List<Team> teams)
        {
            string teamName = line[1];
            ValidateTeamExists(teams, teamName);
            Team team = teams.First(t => t.TeamName == teamName);
            Console.WriteLine(team);
        }

        static void RemovePlayer(string[] line, List<Team> teams)
        {
            string teamName = line[1];
            string playerName = line[2];
            Team team = teams.First(t => t.TeamName == teamName);
            team.RemovePlayer(playerName);
        }

        static void AddPlayer(string[] line, List<Team> teams)
        {
            string teamName = line[1];
            Team team = new Team(teamName);
            ValidateTeamExists(teams, teamName);

            string playerName = line[2];
            int endurance = int.Parse(line[3]);
            int sprint = int.Parse(line[4]);
            int dribble = int.Parse(line[5]);
            int passing = int.Parse(line[6]);
            int shooting = int.Parse(line[7]);

            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);
            Player player = new Player(playerName, stats);
            team = teams.First(t => t.TeamName == teamName);
            team.AddPlayer(player);
        }

        public static void ValidateTeamExists(List<Team> teams, string teamName)
        {
            if (!teams.Any(t => t.TeamName == teamName))
            {
                throw new ArgumentException($"Team {teamName} does not exist.");
            }
        }
    }
}
