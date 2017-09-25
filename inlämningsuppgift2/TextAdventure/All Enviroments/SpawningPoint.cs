using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class SpawningPoint : Rooms
    {
        string MagicalBeans = "Magiska frön";
        public SpawningPoint()
            : base(
            Name: "\nDu befinner dig i ett litet hus ",
            Description: "\nVäggarna är målade i grönt. Du ser ett fönster intill en dörr till vänster i huset, " +
                 "du ser en trädgård. \nPå den andra sidan, ser du en dörr till höger, den leder ut.. ")
        {
            Console.WriteLine(Name + Description);

            Console.WriteLine("Det finns en sammetspåse med magiskafrön som du kan plocka upp");

            ItemsInRoom.Add(new Items.Items(MagicalBeans, "Magiska frön som växer direkt om du har rätt tillbehör vid plantering"));

            string input = Console.ReadLine().ToUpper();

            if (input == "GÅ VÄNSTER")
            {
                Game.currentRoom = Game.garden;
            }

            if (input == "GÅ HÖGER")
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
            Items.Inventory.itemList.Add(new Items.Items(MagicalBeans, "Magiska frön som växer direkt om du har rätt tillbehör vid plantering"));
        }
    }
}

