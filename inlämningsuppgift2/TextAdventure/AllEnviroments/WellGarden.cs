using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventure.AllClasses.Items;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class WellGarden : Rooms
    {
        public WellGarden()
                        : base(
                  Name: "Brunn gården ",
                  Description: "\nEn brunn för att hämta vatten för att kunna plantera äppleträd")
            //Metodanrop för saker man kan ta upp, samt djur
        {
            Console.WriteLine(Name + Description);
            string input = Console.ReadLine().ToUpper();

            List<Item> WellGardenList = new List<Item>();
            WellGardenList.Add(Apple);
            //bucket samt bucketfilledwater
            //Få ut items till listor på respektive rum



            //do 
            //{
            //    switch(input)
            //    {
            //        case "PICK UP":
            //            //lista som addar hinken
            //            break;
            //        case "FILL WITH WATER":
            //            //Fyller hinken med vatten och gör om hinken till waterbucket
            //            break;
            //        case "GIVE MUSHROOMS":
            //            //Tar bort mushrooms i inventory
            //           // Console.WriteLine("Grisen blir nöjd och lämnar dig i fred");
            //            //Tar bort grisen från rummet för alltid
            //            break;

            //        case "NORTH":
            //            MushroomOutHouse mushroom = new MushroomOutHouse();
            //            break;
            //    }
            //} while (input == "NORTH");


        }
    }
}
