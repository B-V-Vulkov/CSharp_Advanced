namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get { return this.name; }
        }

        public int Badges
        {
            get { return this.badges; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
        }

        public Trainer(string name)
        {
            this.name = name;
            this.badges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void RemoveDeadPokemons()
        {
            List<Pokemon> newPokemonList = new List<Pokemon>();

            foreach (var pokemon in pokemons)
            {
                if (pokemon.Health > 0)
                {
                    newPokemonList.Add(pokemon);
                }
            }
            pokemons = newPokemonList;
        }

        public void IncreaseBadges()
        {
            this.badges++;
        }

        public void DecreaseBadges()
        {
            this.badges--;
        }
    }
}
