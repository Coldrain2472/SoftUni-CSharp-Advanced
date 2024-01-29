using PokemonTrainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer;
public class StartUp
{
    public static void Main(string[] args)
    {
        string commandInfo = string.Empty;
        List<Trainer> trainers = new List<Trainer>();
        while ((commandInfo = Console.ReadLine()) != "Tournament")
        {
            // {trainerName} {pokemonName} {pokemonElement} {pokemonHealth}
            string[] command = commandInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string trainerName = command[0];
            string pokemonName = command[1];
            string pokemonElement = command[2];
            int pokemonHealth = int.Parse(command[3]);
            Trainer currentTrainer = trainers.SingleOrDefault(t => t.Name == trainerName);

            if (currentTrainer == null)
            {
                trainers.Add(CreateTrainer(trainerName, 0, (CreatePokemon(pokemonName, pokemonElement, pokemonHealth))));
            }
            else
            {
                currentTrainer.Pokemons.Add(CreatePokemon(pokemonName, pokemonElement, pokemonHealth));
            }
        }

        while ((commandInfo = Console.ReadLine()) != "End")
        {
            // "Fire", "Water", "Electricity"
            foreach (Trainer trainer in trainers)
            {
                trainer.CheckPokemon(commandInfo);
            }
        }

        foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }

    static Pokemon CreatePokemon(string name, string element, int health)
    {
        Pokemon pokemon = new Pokemon(name, element, health);
        return pokemon;
    }

    static Trainer CreateTrainer(string name, int badges, Pokemon pokemon)
    {
        List<Pokemon> pokemons = new List<Pokemon>();
        pokemons.Add(pokemon);
        Trainer trainer = new Trainer(name, badges, pokemons);
        return trainer;
    }
}