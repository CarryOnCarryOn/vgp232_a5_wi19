using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Data
{
    public class Pokedex
    {
        [XmlArray("Pokemons")]
        [XmlArrayItem("Pokemon")]
        public List<Pokemon> Pokemons { get; set; }

        public Pokedex()
        {
            Pokemons = new List<Pokemon>();
        }

        public Pokemon GetPokemonByIndex(int index)
        {
            foreach (Pokemon pokemon in Pokemons)
            {
                if (pokemon.Index == index)
                {
                    return pokemon;
                }
            }
            throw new NotImplementedException();
        }

        public Pokemon GetPokemonByName(string name)
        {
            foreach (Pokemon pokemon in Pokemons)
            {
                if(pokemon.Name==name)
                {
                    return pokemon;
                }
            }
            throw new NotImplementedException();
        }

        public List<Pokemon> GetPokemonsOfType(string type)
        {
            List<Pokemon> listp=new List<Pokemon>();
            foreach (Pokemon pokemon in Pokemons)
            {
                if (pokemon.Type1 == type)
                {
                    listp.Add(pokemon);
                }
                else if(pokemon.Type2 == type)
                {
                    listp.Add(pokemon);
                }
            }

            return listp;
            // Note to check both Type1 and Type2
            throw new NotImplementedException();
        }

        public Pokemon GetHighestHPPokemon()
        {
            Pokemon higestHp = new Pokemon();
            for (int i = 1; i < Pokemons.Count; i++)
            {
                if (Pokemons[i].HP >= Pokemons[i-1].HP)
                {
                    higestHp = Pokemons[i];
                }
            }
            return higestHp;
                throw new NotImplementedException();
        }

        public Pokemon GetHighestAttackPokemon()
        {
            Pokemon higestAttack = new Pokemon();
            for (int i = 1; i < Pokemons.Count; i++)
            {
                if (Pokemons[i].Attack >= Pokemons[i -1].Attack)
                {
                    higestAttack = Pokemons[i];
                }
            }
            return higestAttack;
            throw new NotImplementedException();
        }

        public Pokemon GetHighestDefensePokemon()
        {
            Pokemon higestDefense = new Pokemon();
            for (int i = 1; i < Pokemons.Count; i++)
            {
                if (Pokemons[i].Defense >= Pokemons[i - 1].Defense)
                {
                    higestDefense = Pokemons[i];
                }
            }
            return higestDefense;
            throw new NotImplementedException();
        }

        public Pokemon GetHighestMaxCPPokemon()
        {
            Pokemon higestCp = new Pokemon();
            for (int i = 1; i < Pokemons.Count; i++)
            {
                if (Pokemons[i].MaxCP >= Pokemons[i - 1].MaxCP)
                {
                    higestCp = Pokemons[i];
                }
            }
            return higestCp;
            throw new NotImplementedException();
        }

    }
}
