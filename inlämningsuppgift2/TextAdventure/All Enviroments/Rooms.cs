using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{ //Bas klassen till alla subklasser -miljö-
    public class Rooms //Alla mina rum
    {
        public string Name, Description;

        public Rooms(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
            ItemsInRoom = new List<Items.Items>();
        }

        public List<Items.Items> ItemsInRoom { get; set; }
    }
}