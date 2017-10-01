using System;
using System.Threading;
namespace TextAdventure.Animals
{
    public class Pig : Animals
    {
        /*
		public static void PigToString()
		{
			
			Console.WriteLine("Ett aggresivt vildsvin står framför dig. " + "\n" +
				"Han verkar väldigt hungrig och har ingenting att äta." + "\n");
		}

		public static bool PigSolveProblem()
		{
			Console.WriteLine("Vildsvinet äter svamparna och går sedan sin väg.");
			return false;

		}

		public static bool PigAction()
		{
			Console.WriteLine("Vildsvinet rör sig mot dig och knuffar bort dig från området.");
			return false;
		}
*/
        /*
		public Pig()
		{
			string name = "Vildsvin";
			string info = "Ett aggresivt vildsvin står framför dig. " + "\n" +
				"Han verkar väldigt hungrig och har ingenting att äta." + "\n";

			this.Name = name;
			this.Info = info;
		}
		*/

        //==========ICKE-STATIC==================

        public void ToScreen()
        {
            Console.WriteLine(Info);
        }

        public void SolveProblem()
        {
            Console.Clear();
            Console.WriteLine("Grisen äter svamparna och går sedan sin väg.");

            //GameSession.well.ListOfAnimals.Remove(GameSession.pig);
            Thread.Sleep(4000);
            //return false;

        }

        public void Action()
        {
            Console.Clear();
            Console.WriteLine("Grisen rör sig mot dig och knuffar bort dig från området.");
            Thread.Sleep(4000);
            //return false;
        }

        public Pig()
        {
            this.Name = "Gris";
            this.Info = "En aggresiv [gris] står framför dig. " + "\n" +
                "Han verkar väldigt hungrig och har ingenting att äta." + "\n";


        }

    }
}
