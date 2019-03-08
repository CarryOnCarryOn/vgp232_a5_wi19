using NUnit.Framework;
using Assignment5.Data;
using System.Collections.Generic;

namespace Tests
{
  
}
using NUnit.Framework;
using Assignment5.Data;
using System.Xml;
using System;

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
        public void UnlockedItemsAtLevelTest()
        {
            int numberofunlockitem = 0;
            ItemsData data = new ItemsData();
            Item testitem = new Item();
            int level = 30;
            using (XmlReader itemReader = XmlReader.Create("itemData.xml"))
            {
                while (itemReader.Read())
                {
                    if (itemReader.IsStartElement())
                    {
                        switch (itemReader.Name.ToString())
                        {
                            case "Name":
                                testitem.Name = itemReader.ReadElementContentAsString();
                                break;
                            case "UnlockRequirement":
                                testitem.UnlockRequirement = itemReader.ReadContentAsInt();
                                break;
                            case "Description":
                                testitem.Description = itemReader.ReadElementContentAsString();
                                break;
                            case "Effect":
                                testitem.Effect = itemReader.ReadElementContentAsString();
                                break;
                            default:
                                break;
                        }
                        data.Items.Add(testitem);
                    }
                    Console.WriteLine("");
                }
            }
            foreach (Item item in data.Items)
            {
                if (item.UnlockRequirement <= level)
                {
                    numberofunlockitem++;
                }
            }
            Assert.AreEqual(numberofunlockitem, 15);
        }

        [TestCase]
        public void FindItemTest()
        {
            bool isfound = false;
            ItemsData data = new ItemsData();
            Item testitem = new Item();
            string name = "Max Potion";
            string name1;
            int number1;
            using (XmlTextReader itemReader = new XmlTextReader ("itemData.xml"))
            {
                while (itemReader.Read())
                {
                    if (itemReader.IsStartElement())
                    {
                        switch (itemReader.Name.ToString())
                        {
                            case "Name":
                                name1 = itemReader.ReadElementContentAsString();
                                testitem.Name = name1;
                                break;
                            case "UnlockRequirement":
                                number1 = itemReader.ReadContentAsInt();
                                testitem.UnlockRequirement = number1;
                                break;
                            case "Description":
                                name1 = itemReader.ReadElementContentAsString();
                                testitem.Description = name1;
                                break;
                            case "Effect":
                                name1 = itemReader.ReadElementContentAsString();
                               testitem.Effect=name1;
                                break;
                                  default:
                                break;
                        }
                        data.Items.Add(testitem);
                    }
                    Console.WriteLine("");
                }
            }
            foreach (Item item in data.Items)
            {
                if (item.Name == name)
                {
                    isfound=true;
                }
            }
            Assert.AreEqual(isfound, true);
        }
    }
}