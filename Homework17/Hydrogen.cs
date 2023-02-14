using System;
namespace Homework17
{
	public class Hydrogen
	{
        private Oxygen? oxygen1;

        public Oxygen? Oxygen1 { get => oxygen1; set => oxygen1 = value; }

        public Hydrogen()
		{
		}

        public void React(Oxygen oxygen)
        {
            this.oxygen1 = oxygen;
        }
    }
}

