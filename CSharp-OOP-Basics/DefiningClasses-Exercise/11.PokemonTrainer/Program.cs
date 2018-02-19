using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
    class Program
    {
        static void Main()
        {
            string line;
            List<Trainer> trainers = new List<Trainer>();

            while ((line = Console.ReadLine()) != "Tournament")
            {
                var info = line.Split();
                var trainerName = info[0];
                var pokemonName = info[1];
                var pokemonElement = info[2];
                var pokemonHealth = int.Parse(info[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = new Trainer(trainerName, pokemon);

                if (!trainers.Any(t => t.Name == trainerName))
                {
                    trainers.Add(trainer);
                }
                else
                {
                   var tr = trainers.First(t => t.Name == trainerName);
                    tr.pokemons.Add(pokemon);
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var tr in trainers)
                {
                    if (tr.pokemons.Any(p => p.Element == command))
                    {
                        tr.AddBadge();
                    }
                    else
                    {
                        foreach (var pokemon in tr.pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        for (int i = 0; i < tr.pokemons.Count; i++)
                        {
                            if (tr.pokemons[i].Health <= 0)
                            {
                                tr.pokemons.Remove(tr.pokemons[i]);
                                i++;
                            }
                        }
                    }
                }
            }

            foreach (var t in trainers.OrderByDescending(b => b.Badges))
            {
                Console.WriteLine($"{t.Name} {t.Badges} {t.pokemons.Count}");
            }
        }
    }
}
