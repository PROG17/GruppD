using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{
    class Forest : Rooms
    {
        List<Item> ItemList = new List<Item>();

        public Forest()
                    : base(
                  Name: "Skogen",
                  Description: "\nDet här är en skog med faliga djur, var på din vakt! ")

        /* 
         * //allt som behövs i ett rum
         * 
         * Description " Det dhär är en skog" Spelplanen
         * Inventory  skog = new inventory
         * djur = new djur
         * 
         * //kalla på ett rum
         * 
         * lista för djur, och en för items
         * 
         * 
         */
        {

            //
            ItemList.Add("Gödsel");


            List<string> Compass = new List<string>();
            Compass.Add("SOUTH");



        }
    }
}
