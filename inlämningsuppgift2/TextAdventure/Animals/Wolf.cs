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

        // Återgår till gamla konstruktorn
        /*
        public Wolf(string name)
        {
            name = "Varg";
            WolfToString();
            //     this.Name = name;
            //     this.Info = info;
        }
        */
        public static bool WolfToString()
        {
            string info = "Du hör ett fruktansvärt morrande och vänder dig om, och får se en varg börja närma sig";
            Console.WriteLine(info);
            return true;
        }

        public static bool WolfSolveProblem()
        {
            Console.WriteLine("Du skrämmer vargen med din fackla och han springer iväg, och syns aldrig till igen.");
            return false;
        }

        public static bool WolfAction()
        {
            Console.WriteLine("Vargen hoppar på dig och biter så att du dör ögonblickligen!");
            return false;
        }

        public Wolf()
        {
            this.Name = "Varg";
            this.Info = "Du hör ett fruktansvärt morrande och vänder dig om, och får se en varg börja närma sig.";
        }
    }
}
