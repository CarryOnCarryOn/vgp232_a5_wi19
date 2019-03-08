using Assignment5.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemsData data = new ItemsData();
            Item testitem = new Item();
            Console.WriteLine("Welcome to Assignment 5 - Pokemon Edition");
            // TODO: load the pokemon151 xml
            XmlDocument loadPokemon151 = new XmlDocument();
            loadPokemon151.Load("pokemon151.xml");

            // TODO: Add item reader and print out all the items
            using (XmlReader itemReader = XmlReader.Create("itemData.xml"))
            {
                while (itemReader.Read())
                {
                    if (itemReader.IsStartElement())
                    {
                        switch (itemReader.Name.ToString())
                        {
                            case "Name":
                                Console.WriteLine("Item Name : " + itemReader.ReadElementContentAsString());

                                
                                break;
                            case "UnlockRequirement":
                                Console.WriteLine("UnlockRequirement : " + itemReader.ReadElementContentAsFloat());
                            
                                break;
                            case "Description":
                                Console.WriteLine("Description : " + itemReader.ReadElementContentAsString());
                              
                                break;
                            case "Effect":
                                Console.WriteLine("Effect : " + itemReader.ReadElementContentAsString());
                                
                                break;
                        }
                        data.Items.Add(testitem);
                    }
                    Console.WriteLine("");
                }
            }







            // TODO: hook up item data to display with the inventory

            var source = new Inventory()
                {
                    ItemToQuantity = new Dictionary<object, object> { { "Poke ball", 10 }, { "Potion", 10 } }
                };


            // TODO: move this into a inventory with a serialize and deserialize function.

            source.Serialize(source);
            source.Deserialize("inventory.xml");

          
            


            Console.ReadKey();
        }
    }
}
