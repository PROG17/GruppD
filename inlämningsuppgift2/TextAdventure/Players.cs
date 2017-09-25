using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventure.Items;
using TextAdventure.AllClasses.AllEnviroments;

namespace TextAdventure.AllClasses
{
    class Players
    {
        public string name; //namnet på spelaren. Kommer skrivas ut om spelaren dör eller förlorar sedan!
        public string OutPut()
        {
            return "Namnet på spelaren är: " + name;
        }

        public void DropItem(string itemname)
        {
            Items.Items itemToDrop = null;
            //Söker igenom items i inventory

            foreach (var item in Inventory.itemList)
            {
                if (item.Name == itemname)
                {
                    itemToDrop = item;
                    break;
                }
            }
            if (itemToDrop == null)            //Om inte hittad
            {
                Console.WriteLine($"Error: finns inget item som heter {itemname} i inventory.");
                return;
            }

            var room = Game.currentRoom;
            room.ItemsInRoom.Add(itemToDrop);  //lägger till items till rummet
            Inventory.itemList.Remove(itemToDrop);   //raderar från inventory
        }
    }
}
