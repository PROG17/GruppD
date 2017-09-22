using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class House : Rooms
    {
        public House()
            : base(
            Name: "\nDu befinner dig i ett litet hus ",
            Description: "\nVäggarna är målade i grönt. Du ser ett fönster intill en dörr till vänster i huset, " +
                 "du ser en trädgård. \nPå den andra sidan, ser du en dörr till höger, den leder ut.. ")
        {
            Console.WriteLine(Name + Description);


            //    Console.WriteLine("Vill du gå till vänster (LEFT) till trädgården eller höger(RIGHT) ut?");
            //    string input = Console.ReadLine().ToUpper();

            //    do
            //    {
            //        switch (input)
            //        {

            //            case "LEFT":
            //               // Rooms currentRoom = ;
            //                break;

            //            case "RIGHT":
            //                // WellGarden wellgarden =
            //                break;
            //        }
            //    } while (true);
            //}     

            //inventory för huset
            //Så när inventory i rummet plockas upp så försvinner den in i spelarens "backpack"
            //Spelaren kan droppa saker som läggs i inventory hus
            // Egen metod för inventory hus
            //Lista med exits, möjlig väg? 
        }
    }
}
