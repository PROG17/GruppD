using System;
namespace TextAdventure.Animals
{
    public class Bear //: Animals
    {
		public static void BearToString()
		{
			Console.WriteLine("En enorm Grizzlybjörn uppenbarar sig framför dig och börjar röra sig åt ditt håll.");
		}

		public static bool BearSolveProblem()
		{
			Console.WriteLine("Grizzlybjörnen ryggar tillbaka när han får se facklan, och lunkar iväg.");
			return false;
		}

		public static bool BearAction()
		{
			Console.WriteLine("Grizzlybjörnen höjer tassen och slår till dig med ett kraftigt slag. Du dör ögonblickligen");
			return false;
		}

        /*
		public static Bear()
		{
			string name = "Grizzlybjörn";
			string info = "En enorm Grizzlybjörn uppenbarar sig framför dig och börjar röra sig åt ditt håll.";

			this.Name = name;
			this.Info = info;
		}
		*/

        //=============ICKE-STATIC==========================


        /*
		public void BearToString()
		{
			Console.WriteLine();
			Console.WriteLine(Info);
		}

		public bool BearSolveProblem()
		{
			Console.WriteLine("Grizzlybjörnen ryggar tillbaka när han får se facklan, och lunkar iväg.");
			return false;
		}

		public static bool BearAction()
		{
			Console.WriteLine("Grizzlybjörnen höjer tassen och slår till dig med ett kraftigt slag. Du dör ögonblickligen");
			return false;
		}


		public Bear()
        {
            string name = "Grizzlybjörn";
            string info = "En enorm Grizzlybjörn uppenbarar sig framför dig och börjar röra sig åt ditt håll.";

            this.Name = name;
            this.Info = info;
        }
        */
    }
}
