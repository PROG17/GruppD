using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class MushroomOutHouse : Rooms
    {

        public MushroomOutHouse()
            : base
        (
                  Name: "Truffelsvamp",
                  Description: "\nFramför dig har du en jätte stor truffelsvamp. Till norr har du skogen med farliga djur. Till söder har du brunn med vatten.")

        {
            Console.WriteLine(Name + Description);


            //Console.WriteLine("Vill du plocka upp truffelsvampen?");
            //string input = Console.ReadLine().ToUpper();
            //do
            //{
            //    switch(input)
            //    {
            //        case "Ja":
            //            //Truffelsvampen läggs in i listan för spelarens innehåll i backpack
            //            break;

            //        case "Nej":
            //            break;

            //        case "NORTH":
            //            Forest forest = new Forest();
            //            break;

            //        case "SOUTH":
            //            // WellGarden wellgarden =
            //            break;
            //    }

            //inventory för huset
            //Så när inventory i rummet plockas upp så försvinner den in i spelarens "backpack"
            //Spelaren kan droppa saker som läggs i inventory hus

            //Lägg möjliga exit i lista
            //    } while (true);
        }

    }

}
