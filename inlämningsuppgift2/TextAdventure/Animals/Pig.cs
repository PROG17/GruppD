using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses
{
    public class Pig : Animals
    {

            public void PigToString()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Info);
            }

            public bool PigSolveProblem()
            {
                Console.WriteLine("Vildsvinet äter svamparna och går sedan sin väg.");
                return false;
            }

            public bool PigAction()
            {
                Console.WriteLine("Vildsvinet rör sig mot dig och knuffar bort dig från området.");
                return false;
            }

            public Pig(string name, string info)
            {
                name = "Vildsvin";
                info = "\nEtt aggresivt vildsvin står framför dig. " + "\n" +
                    "Han verkar väldigt hungrig och har ingenting att äta." + "\n";
                this.Name = name;
                this.Info = info;
            }
        }
}
