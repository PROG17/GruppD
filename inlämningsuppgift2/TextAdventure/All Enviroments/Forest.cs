using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventure.AllClasses;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class Forest : Rooms
    { 
        string manure = "Gödsel";

        List<Animals> listOfAnimals = new List<Animals>();

        Wolf wolf = new Wolf("Varg"); //Lägger till från klassen Björn/Varg

        public List<Animals> ListOfAnimals
        {
            get { return listOfAnimals; }
            set { listOfAnimals = value; }
        }

        public Forest()
                    : base
                  (Name: "Skogen",
                  Description: "\nDu står mitt i en skogsglänta med stora träd omkring dig som bildar en mur av skog.")
        {     
                Console.WriteLine(Name + Description);
                ItemsInRoom.Add(new Items.Items(manure, "Bra till näring för plantage"));

                listOfAnimals.Add(wolf);                //Skapar en ny varg

                foreach (var animals in listOfAnimals)
                {
                    Console.WriteLine(animals);
                }


            string input = Console.ReadLine().ToUpper();

            if (input == "SÖDER")
            {
                Game.currentRoom = Game.mushroomOutHouse;
            }
            else
            {
                Console.WriteLine("Det finns ingen väg ditåt.");
            }
        }

        public void GivePlayerSomething()
        {
            Items.Inventory.itemList.Add(new Items.Items(manure, "Bra till näring för plantage"));
        }
    }
}
