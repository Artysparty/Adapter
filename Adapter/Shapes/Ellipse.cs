using System;
namespace Adapter.Shapes
{
	public class Ellipse
	{
        private string ellipse { get; set; }
        public float BigSemiaxis { get; set; }
        public float SmallSemiaxis { get; set; }

        public Ellipse(float BigSemiaxis, float SmallSemiaxis)
        {
            this.BigSemiaxis = BigSemiaxis;
            this.SmallSemiaxis = SmallSemiaxis;
            ellipse = "";
        }

        public void Calculate()
        {
            ellipse = "Ellipse";
        }

        public void Apply()
        {
            Console.WriteLine(ellipse);
        }
    }
}

