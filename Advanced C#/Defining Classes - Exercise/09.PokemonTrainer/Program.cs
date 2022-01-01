using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string text;

            text = GetTrainer(trainers);

            string elementInput;

            while ((elementInput = Console.ReadLine()) != "End")
            {
                foreach ((string trainerName, Trainer trainer) in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == elementInput))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        int count = trainer.Pokemons.Count;

                        for (int i = 0; i < count; i++)
                        {
                            Pokemon pokemon = trainer.Pokemons[i];

                            pokemon.Health -= 10;

                            if (pokemon.Health < 10)
                            {
                                trainer.Pokemons.Remove(pokemon);
                                i--;
                            }
                        }
                    }
                }

            }

            trainers = trainers.OrderByDescending(t => t.Value.NumberOfBadges)
                 .ToDictionary(k => k.Key, v => v.Value);

            Print(trainers);

        }

        private static void Print(Dictionary<string, Trainer> trainers)
        {
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count}");
            }
        }

        private static string GetTrainer(Dictionary<string, Trainer> trainers)
        {
            string text;
            while ((text = Console.ReadLine()) != "Tournament")
            {
                string[] arg = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = arg[0];
                string pokemonName = arg[1];
                string pokemonElement = arg[2];
                double pokemonHealth = double.Parse(arg[3]);


                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainerName, trainer);
                }

                trainers[trainerName].Pokemons.Add(pokemon);
            }

            return text;
        }
    }
}
