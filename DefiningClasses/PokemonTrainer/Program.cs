using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Tournament")
                {
                    break;
                }
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }
                trainer.Pokemons.Add(pokemon);
            }
            while (true)
            {
                string power = Console.ReadLine();
                if (power == "End")
                {
                    break;
                }
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (trainers[i].Pokemons.Any(x => x.Element == power))
                    {
                        trainers[i].BadgesCount++;
                    }
                    else
                    {
                        ReduceHealth(trainers[i].Pokemons);
                    }
                }
            }

            trainers = trainers.OrderByDescending(x => x.BadgesCount).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, trainers));
        }
        static void ReduceHealth(List<Pokemon> pokemons)
        {
            for (int j = 0; j < pokemons.Count; j++)
            {
                pokemons[j].Health -= 10;
                if (isDead(pokemons[j].Health))
                {
                    pokemons.RemoveAt(j);
                    j--;
                }
            }
        }
        static bool isDead(int pokemonHealth)
        {
            return pokemonHealth <= 0;
        }
    }
}
