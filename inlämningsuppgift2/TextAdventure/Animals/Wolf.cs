using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses
{
    class Wolf : Animals 
        //Ändrade lite i djuren för att kunna få ut dem i rummen. Går säkert göra på ett annat bättre sätt!!
    {

        public Wolf(string name)
        {
            name = "Grizzlybjörn";
            WolfToString();
            //     this.Name = name;
            //     this.Info = info;
        }
        public static bool WolfToString()
        {
            string info = "En enorm grizzlybjörn uppenbarar sig framför dig och börjar röra sig åt ditt håll.";
            Console.WriteLine(info);
            return true;
        }

        public static bool WolfSolveProblem()
        {
            Console.WriteLine("Grizzlybjörnen  ryggar tillbaka när han får se facklan, och lunkar iväg.");
            return false;
        }

        public static bool WolfAction()
        {
            Console.WriteLine("Vargen biter i dig så att du dör ögonblickligen av blodförlust");
            return false;
        }
    }
}
