using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventure.AllClasses.AllEnviroments;

namespace TextAdventure.AllClasses
{
    class Game
    {
        bool start = true;
        public static Rooms currentRoom;
        public static Players players = new Players();
        public static SpawningPoint spawn = new SpawningPoint();
        public static Garden garden = new Garden();
        public static WellGarden wellGarden = new WellGarden();
        public static MushroomOutHouse mushroomOutHouse = new MushroomOutHouse();
        public static Forest forest = new Forest();
        //Dessa ska vara ovan för att jag ska kunna använda dem utan att skapa nya rum i navigeringen/Emma


        public Game()
        {

            Rooms rooms = new Rooms("", "");
            Pig pig = new Pig("", "");
            Wolf wolf = new Wolf("");

            //alla rum:       

            while (start == true)
            {
                Console.WriteLine("Välkommen till Äppleträdet - äventyrs spel!");
                currentRoom = spawn;
                //  rooms.ItemsInRoom = currentRoom("","");
                //djur och rum initieras här
                //current room behövs

                spawn.GivePlayerSomething(); //en metod som lägger till föremål i Inventory i rummen

                players.DropItem("Denna ska vara när man släpper ner föremål i rummet. Text exempel: Du släppte ner **** i rummet. ");

                currentRoom.ItemsInRoom.Add(new Items.Items("Föremålet som droppades läggs in i rummets inventory", ""));



                //Alla metoder och klasser ska kopplas in hit för att i Main ska vi endast skapa ett Game game = new Game();

                //Man spawnar i sitt hus, till vänster finns en liten trädgård med staket.
                // I backpack så har man en fackla som man kan tända vid skogen för att skrämma bort odjur
                //Om denna används så finns det också en fackla som man kan plocka upp på vägen

                //I huset finns det en påse frön som man ska plantera i trädgården
                //Sedan måste man gå ut ur huset för att hämta vatten från söder och gödsel från skogen i norr.

                //På vägen stöter man på olika hinder , djur som är vid brunnen där vattnet finns.

                //I skogen finns djur som man kan skrämma bort med hjälp av facklan, har man ingen fackla så dör man

                //Så för att klara pusslet plantera äppleträd så krävs det;

                //frön, vatten och gödsel

                //Players player = new Players();
                //Console.Write("Mata in ditt namn på spelaren: ");
                //player.name = Console.ReadLine();

                //För att få ut från Inventory
                //    Inventory inventory = new Inventory();

                //Console.Write("I din ryggsäck så har du " + inventory.Apple + " och " + inventory.Torch + " ");
                //Dessa ska redan finnas i ryggsäcken

                //SpawningPoint startGame = new SpawningPoint();
            }
        }
    }
}

