using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventure.AllClasses;
using TextAdventure.Items;
using TextAdventure.AllClasses.AllEnviroments;

namespace TextAdventure
{
    class Commands
    {
        public static string CommandsToString()
        {
            string commands = "// DINA VAL // | * ANVÄND * | * PLOCKA UPP * | * SLÄPP * | * KOMBINERA * |\n";
            return commands;
        }

        public Commands(string command)
        {
            //Commands baserade på rörelse (go, north, south, ....)

            //kolla först go i if-sats och sen riktning

            //Commands baserade kring items (använd, plocka upp, släpp, kombinera)


            if (command.Length >= 3 && command.Substring(0, 6) == "använd")
            {
                if (command == "använd")
                {
                    Console.WriteLine("Du måste specifiera ett objekt");
                }
                if (Items.Inventory.itemList.Exists(Items => Items.Name == command.ToUpper().Substring(4))) //Antagligen fel siffra för Substring
                {
                    Console.WriteLine();
                }
                else
                {

                }
            }

            if (command.Length >= 3 && command.Substring(0, 10) == "plocka upp") //Antagligen fel siffra för Substring
            {
                if (command == "plocka upp")
                {
                    Console.WriteLine("Du måste specifiera ett objekt");
                }


                //if (currentRoom.Exists(Items => Items.name == command.ToUpper().Substring(4))) //Antagligen fel siffra för Substring och finns ingen currentRoom just nu
                //{
                //    Console.WriteLine("Något vi vill ska stå när saker plockas upp");
                //    //lägga till item i player-inv.
                //    //ta bort item i plats-inv.
                //}
                else
                {
                    //annars finns inte objektet man försöker plcoka upp?
                }
                if (command.Length >= 3 && command.Substring(0, 5) == "släpp") //Antagligen fel siffra för Substring
                {
                    if (command == "släpp")
                    {
                        Console.WriteLine("Du måste specifiera ett objekt");
                    }
                    if (Items.Inventory.itemList.Exists(Items => Items.Name == command.ToUpper().Substring(7))) //Antagligen fel siffra för Substring
                    {
                        Console.WriteLine();
                        //lägga till item i plats-inv.
                        //ta bort item i player-inv.
                    }
                    else
                    {
                        //annars så har man inte objektet man försöker släppa?
                    }
                }
                if (command.Length >= 3 && command.Substring(0, 9) == "kombinera") //Antagligen fel siffra för Substring
                {
                    if (command == "kombinera")
                    {
                        Console.WriteLine("Du måste ange två objekt som du vill kombinera");
                    }

                }
            }
        }
    }
}
