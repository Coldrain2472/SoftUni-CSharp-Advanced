using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
	public class Trainer
	{
		public Trainer(string name, int badges, List<Pokemon> pokemon)
		{
			Name = name;
			Badges = badges;
			Pokemons = pokemon;
		}

		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int badges;
		public int Badges
		{
			get { return badges; }
			set { badges = value; }
		}

        public List<Pokemon> Pokemons { get; set; }

        public void CheckPokemon(string element)
        {
            if (Pokemons.Any(p => p.Element == element))
            {
                Badges++;
            }
            else
            {
                for (int i = 0; i < Pokemons.Count; i++)
                {
                    Pokemons[i].Health -= 10;

                    if (Pokemons[i].Health <= 0)
                    {
                        Pokemons.Remove(Pokemons[i]);
                        i--;
                    }
                }
            }

        }
    }
}
