using Assignment5.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Assignment 5 - Pokemon Edition");

            PokemonReader reader = new PokemonReader();
            Pokedex pokedex = reader.Load("pokemon151.xml");
           
            // List out all the pokemons loaded
            foreach (Pokemon pokemon in pokedex.Pokemons)
            {
                Console.WriteLine(pokemon.Name);
            }

            PokemonBag mybag=new PokemonBag();
            mybag.Pokemons.Add(1);
            mybag.Pokemons.Add(1);
            mybag.Pokemons.Add(6);
            mybag.Pokemons.Add(151);
            mybag.Pokemons.Add(149);


            FileStream fs = new FileStream(@"serializePokemon.dat", FileMode.Create);//path of file
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, mybag);
            fs.Close();

            fs = new FileStream(@"serializePokemon.dat", FileMode.Open);
            BinaryFormatter nbf = new BinaryFormatter();
            PokemonBag mylist = nbf.Deserialize(fs) as PokemonBag;
            Console.WriteLine("\nList of the the pokemons caught");
            foreach (int i in mylist.Pokemons)
            {
                
                Console.WriteLine(pokedex.GetPokemonByIndex(i).Name);
            }
            Console.WriteLine(pokedex.GetHighestHPPokemon().Name);
            Console.WriteLine(pokedex.GetHighestAttackPokemon().Name);
            Console.WriteLine(pokedex.GetHighestDefensePokemon().Name);
            Console.WriteLine(pokedex.GetHighestMaxCPPokemon().Name);
            // TODO: Add a pokemon bag with 2 bulbsaur, 1 charlizard, 1 mew and 1 dragonite
            // and save it out and load it back and list it out.

            Console.ReadKey();
        }
    }
}
