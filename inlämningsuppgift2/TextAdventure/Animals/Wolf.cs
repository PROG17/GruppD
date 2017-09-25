using System;
namespace TextAdventure.Animals
{
    public class Wolf : Animals
    {
        /*
		public static void WolfToString()
		{
			Console.WriteLine("Du hör ett fruktansvärt morrande och vänder dig om, och får se en varg börja närma sig.");
		}

		public static bool WolfSolveProblem()
		{
			Console.WriteLine("Du skrämmer vargen med din fackla och han springer iväg, och syns aldrig till igen");
			return false;
		}

		public static bool WolfAction()
		{
			Console.WriteLine("Vargen attackerar och äter dig levande!");
			return false;
		}
        */
        /*
		public Wolf()
		{
			string name = "Varg";
			string info = "Du hör ett fruktansvärt morrande och vänder dig om, och får se en varg börja närma sig.";
			this.Name = name;
			this.Info = info;
		}
		*/


        //=============ICKE-STATIC=====================


        public void WolfToString()
		{
			Console.WriteLine(Info);
		}

        public bool WolfSolveProblem()
        {
            Console.WriteLine("Du skrämmer vargen med din fackla och han springer iväg, och syns aldrig till igen");
            return false;
        }

        public bool WolfAction()
        {
            Console.WriteLine("Vargen attackerar och äter dig levande!");
            return false;
        }

        public Wolf()
        {
            this.Name = "Varg";
            this.Info = "Du hör ett fruktansvärt morrande och vänder dig om, och får se en varg börja närma sig.";

        }
    }
}
