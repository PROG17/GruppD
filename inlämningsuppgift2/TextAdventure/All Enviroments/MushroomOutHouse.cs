using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class MushroomOutHouse : Rooms
    {
        string Mushroom = "Truffelsvamp";

        public MushroomOutHouse()
            : base
        (
                  Name: "Truffelsvamp",
                  Description: "\nFramför dig har du en jätte stor truffelsvamp. Till norr har du skogen med farliga djur. Till söder har du brunn med vatten.")

        {
            Console.WriteLine(Name + Description);

            ItemsInRoom.Add(new Items.Items(Mushroom, "Truffelsvamp som vissa djur tycker om"));

            string input = Console.ReadLine().ToUpper();


            if (input == "GÅ VÄNSTER")
            {
                Game.currentRoom = Game.spawn;
            }

            if(input == "GÅ NORR")
            {
                Game.currentRoom = Game.forest;
            }

            if(input == "GÅ SÖDER")
            {
                Game.currentRoom = Game.wellGarden;
            }
            else
            {
                Console.WriteLine("Det finns ingen väg ditåt.");
            }


        }

        public void GivePlayerSomething()
        {
            Items.Inventory.itemList.Add(new Items.Items(Mushroom, "Truffelsvamp som vissa djur tycker om"));
        }

    }

}
