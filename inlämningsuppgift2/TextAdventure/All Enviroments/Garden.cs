using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class Garden : Rooms
    {
        string shovel = "Spade";
        List<string> itemsInGarden = new List<string>();        //Inventory för garden

        public Garden()
                    : base(
                  Name: "Trädgård ",
                  Description: "\nEn lagom stor trädgård, du ser lite jord på en gräsfläck, ett staket runt omkring så här kan du inte ta dig ut. Farlig omgivning bakom staketet!")
        {
            Console.WriteLine(Name + Description);

            ItemsInRoom.Add(new Items.Items(shovel, "Rostig gammal spade, men utmärkt att gräva med")); //Det som finns i inventory i garden

            string input = Console.ReadLine().ToUpper();

            if(input == "HÖGER")
            {
                Game.currentRoom = Game.spawn;              
            }
            else
            {
                Console.WriteLine("Det finns ingen väg ditåt.");
            }
        }

    public void GivePlayerSomething() //Denna funktionen används för att lägga in item i inventory
    {
        Items.Inventory.itemList.Add(new Items.Items(shovel, "Rostig gammal spade, men utmärkt att gräva med"));
    }
}
}
