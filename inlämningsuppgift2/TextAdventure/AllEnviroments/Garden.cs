using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class Garden : Rooms
    {
        public Garden()
                    : base(
                  Name: "Trädgård ",
                  Description: "\nEn lagom stor trädgård, du ser lite jord på en gräsfläck, ett staket runt omkring så här kan du inte ta dig ut. Farlig omgivning bakom staketet!")
        {
            Console.WriteLine(Name + Description );
        }

        //Inventory för garden


    }
}
