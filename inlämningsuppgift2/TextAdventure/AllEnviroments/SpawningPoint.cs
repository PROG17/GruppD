using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class SpawningPoint : Rooms
    {
        public SpawningPoint()
            : base(
            Name: "\nDu befinner dig i ett litet hus ",
            Description: "\nVäggarna är målade i grönt. Du ser ett fönster intill en dörr till vänster i huset, " +
                 "du ser en trädgård. \nPå den andra sidan, ser du en dörr till höger, den leder ut.. ")
        {
            Console.WriteLine(Name + Description);


            //string input = Console.ReadLine().ToUpper();

            //do
            //{

            //    switch (input)
            //    {
            //        case "LEFT":
            //            //statement för left, ut i gården.......


            //            break;

            //        case "RIGHT":
            //            //statement för att gå ut till svamparna
            //            break;

            //    }
            //} while (input == "LEFT" || input == "RIGHT"); //Condition rum ska vara här...



        }
    }
}

