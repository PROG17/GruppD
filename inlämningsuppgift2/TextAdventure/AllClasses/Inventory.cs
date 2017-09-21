using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.AllClasses
{
    class Inventory
    {
        //Här ska backpack items vara

        public string Apple;
        public string Torch;

        public string Output()
        {
            return "Det finns: " + Apple + " och " + Torch + " i ryggsäcken.";
        }

    }
}
