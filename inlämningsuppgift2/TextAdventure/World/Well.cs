using System;
using System.Collections.Generic;
namespace TextAdventure.World
{
    public class Well : Rooms
    {
        /*
        List<Animals.Pig> listOfAnimals = new List<Animals.Pig>();
    

        public List<Animals.Pig> ListOfAnimals
        {
            get
            {
                return listOfAnimals;
            }
            set
            {
                listOfAnimals = value;
            }
        }
        */

        public override void ToScreen()
        {
            Console.WriteLine(Description);

            if(!ListOfAnimals.Contains(GameSession.pig))
            {
                foreach (var item in ListOfItems)
                {
                    if (item == GameSession.bucket)
                    {
                        Console.WriteLine("Bredvid brunnen står det en [hink].");
                    }
                    else
                    {
                        if(item != GameSession.theWell)
                        Console.WriteLine(item.Name + ": " + item.Description);
                    }
                }
            }
            else if(ListOfAnimals.Contains(GameSession.pig))
            {
                GameSession.pig.ToScreen();

            }
        
            
        }

        public Well(GameData.Items theWell, /*GameData.Items bucket, */Animals.Pig pig, Exits north)
        {
            this.Name = "Brunn";
            this.Description = "Du står vid kanten av ängen och framför dig finns en gammal [brunn] med vatten.\n" +
                "En stig leder tillbaka till ängen åt [norr]";
            //this.ListOfItems.Add(bucket);
            this.ListOfItems.Add(theWell);
            this.ListOfAnimals.Add(pig);
            this.ListOfExists.Add(north);
        }
    }
}
