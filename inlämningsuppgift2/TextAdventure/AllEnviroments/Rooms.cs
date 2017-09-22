using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses.AllEnviroments
{ //Bas klassen till alla subklasser -miljö-
    public class Rooms
    {
        public string Name, Description;

        public Rooms(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
            //Det kommer alltid finnas namn på rummen, en beskrivning, alltid ett föremål.

            //but if you make a superclass for all rooms, you can store different rooms in an array thanks to polymorphism
            //List < Room > where Room is superclass of all rooms
        }
    }
}
