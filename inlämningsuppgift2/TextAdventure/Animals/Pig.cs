using System;
namespace TextAdventure.Animals
{
    public class Pig //: Animals
    {
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
        /*
        public void PigToString()
        {
            Console.WriteLine();
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

        public Pig()
        {
            string name = "Vildsvin";
            string info = "Ett aggresivt vildsvin står framför dig. " + "\n" +
                "Han verkar väldigt hungrig och har ingenting att äta." + "\n";

            this.Name = name;
            this.Info = info;
        }
        */
    }
}
