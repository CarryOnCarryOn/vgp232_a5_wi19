using NUnit.Framework;
using Assignment5.Data;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        [TestCase]
        public void GetPokemonByIndexTest()
        {
            int index = 1;
            Pokedex pokedex = new Pokedex();
            PokemonReader reader = new PokemonReader();
            pokedex = reader.Load("pokemon151.xml");
            for (int i = 0; i < pokedex.Pokemons.Count; i++)
            {
                if (pokedex.Pokemons[i].Index == index)
                {
                    Assert.AreEqual(pokedex.Pokemons[i].Index, 1);
                }
            }

        }

        [TestCase]
        public void GetPokemonBynameTest()
        {
            string name = "Bulbasaur";
            Pokedex pokedex = new Pokedex();
            PokemonReader reader = new PokemonReader();
            pokedex = reader.Load("pokemon151.xml");
            for (int i = 0; i < pokedex.Pokemons.Count; i++)
            {
                if (pokedex.Pokemons[i].Name == name)
                {
                    Assert.AreEqual(pokedex.Pokemons[i].Name, "Bulbasaur");
                }
            }

        }
        [TestCase]
        public void GetPokemonsofTypeTest()
        {
            Pokedex pokedex = new Pokedex();
            PokemonReader reader = new PokemonReader();
            pokedex = reader.Load("pokemon151.xml");
            System.Collections.Generic.List<Pokemon> testlist = new System.Collections.Generic.List<Pokemon>();
            testlist = pokedex.GetPokemonsOfType("Grass");

            Assert.AreEqual(testlist.Count, 14);
        }
        [TestCase]

        public void GetHighestHPPokemonTest()
        {
            Pokedex pokedex = new Pokedex();
            PokemonReader reader = new PokemonReader();
            pokedex = reader.Load("pokemon151.xml");
            Pokemon pokemon = pokedex.GetHighestHPPokemon();

            Assert.AreEqual(pokemon.Name, "Mew");
        }
        [TestCase]
        public void GetHighestDSPokemonTest()
        {
            Pokedex pokedex = new Pokedex();
            PokemonReader reader = new PokemonReader();
            pokedex = reader.Load("pokemon151.xml");
            Pokemon pokemon = pokedex.GetHighestDefensePokemon();

            Assert.AreEqual(pokemon.Name, "Mew");
        }
        [TestCase]
        public void GetHighestcpPokemonTest()
        {
            Pokedex pokedex = new Pokedex();
            PokemonReader reader = new PokemonReader();
            pokedex = reader.Load("pokemon151.xml");
            Pokemon pokemon = pokedex.GetHighestMaxCPPokemon();

            Assert.AreEqual(pokemon.Name, "Mewtwo");
        }
        [TestCase]
        public void GetHighestAttackPokemonTest()
        {
            Pokedex pokedex = new Pokedex();
            PokemonReader reader = new PokemonReader();
            pokedex = reader.Load("pokemon151.xml");
            Pokemon pokemon = pokedex.GetHighestAttackPokemon();

            Assert.AreEqual(pokemon.Name, "Mewtwo");
        }
    }
}