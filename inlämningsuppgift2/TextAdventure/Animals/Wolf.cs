using System;
namespace TextAdventure.Animals
{
    public class Wolf : Animals
    {


        public void WolfToString()
		{
			Console.WriteLine();
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
            string name = "Varg";
            string info = "Du hör ett fruktansvärt morrande och vänder dig om, och får se en varg börja närma sig.";
            this.Name = name;
            this.Info = info;
        }
    }
}
