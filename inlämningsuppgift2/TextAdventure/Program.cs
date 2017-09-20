using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AppleTree - Adventure Game");

            //Man spawnar i sitt hus, till vänster finns en liten trädgård med staket.
            //Till höger i huset finns en annan dörr där man behöver en nyckel för att komma ut.

            // I backpack så har man ett äpple och en fackla som man kan tända vid skogen för att skrämma bort odjur
            //Om denna används så finns det också en fackla som man kan plocka upp på vägen

            //Man har ett äpple som man ska äta, av den får man frön som man ska plantera i trädgården
            //Sedan måste man gå ut ur huset för att hämta vatten, gödsel från skogen.

            //På vägen stöter man på olika hinder , djur som är vid brunnen där vattnet finns.

            //I skogen finns djur som man kan skrämma bort med hjälp av facklan, har man ingen fackla så

            //kan man antingen välja att vänta och springa till huset, eller stanna och dö? (Så man har två steg)

            //Så för att klara pusslet plantera äppleträd så krävs det;

            //frön, vatten och gödsel

            Players player = new Players();
            Console.WriteLine("Mata in ditt namn på spelaren: ");

            player.name = Console.ReadLine();

            //För att få ut från Inventory
            Inventory inventory = new Inventory();
            inventory.Apple = "ett äpple";
            inventory.Torch = "en fackla";

            Console.Write("I din ryggsäck så har du " + inventory.Apple + " och " + inventory.Torch + " ");


        }
    }
}
