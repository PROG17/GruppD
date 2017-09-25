using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.Items
{
    public class Inventory //Alexanders Items
    {
        //fält
        public static List<Items> itemList = new List<Items>();   //står som public just nu då jag ville kunna skriva ut den lätt för att se värden.
        //Metoder

        public void Add(Items one)
        {
            itemList.Add(one);
        }

        public void Drop(Items one)
        {
            itemList.Remove(one);
        }

        public static string Print()
        {
            string inventory = "Saker i din ryggsäck ";
            for (int i = 0; i < itemList.Count; i++)
            {
                int item = i + 1;
                inventory += (item + itemList[i].Name);
            }
            return inventory;
        }

        public void Combine(Items one, Items two)
        {
            List<string> CombinedItems = new List<string>();
            CombinedItems.Add(one.Name.ToString());
            CombinedItems.Add(two.Name.ToString());
            if (CombinedItems.Contains("Vatten") && CombinedItems.Contains("Hink"))
            {
                Items WaterBucket = new Items("Vatten hink", "En hink med vatten");
                itemList.Remove(one);
                itemList.Remove(two);
                itemList.Add(WaterBucket);
            }
            //plats för fler möjliga kombinationer
        }
    }
}
