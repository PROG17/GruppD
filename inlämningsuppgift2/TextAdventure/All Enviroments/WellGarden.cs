using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventure.Items;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class WellGarden : Rooms
    {

        List<Animals> listOfAnimals = new List<Animals>();
        Pig pig = new Pig(" " , " "); //Vet inte om texten behövs här?

        public List<Animals> ListOfAnimals
        {
            get { return listOfAnimals; }
            set { listOfAnimals = value; }
        }

        string bucket = "Hink";
        string water = "Vatten";

        public WellGarden()
                        : base(
                  Name: "Brunn gården ",
                  Description: "\nEn brunn för att hämta vatten för att kunna plantera äppleträd")          

        //Metodanrop för saker man kan ta upp, samt djur
        {
            Console.WriteLine(Name + Description);

            ItemsInRoom.Add(new Items.Items(bucket, "Hink för att transportera vätska i"));
            ItemsInRoom.Add(new Items.Items(water, "Behövs för att få växter att växa"));

            pig.PigToString();

            foreach (var animals in listOfAnimals)
            {
                listOfAnimals.Add(pig);
                Console.WriteLine(animals);
            }

            string input = Console.ReadLine().ToUpper();

            if(input == "NORR")
            {
                Game.currentRoom = Game.mushroomOutHouse;
            }
            else
            {
                Console.WriteLine("Finns ingen väg dit");
            }

        }

        public void GivePlayerSomething()
        {
            Items.Inventory.itemList.Add(new Items.Items(bucket, "Hink för att transportera vätska i"));
            Items.Inventory.itemList.Add(new Items.Items(water, "Behövs för att få växter att växa"));
        }

    }
}
