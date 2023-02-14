using System;
namespace Homework17
{
	public class Oxygen
	{
		private Hydrogen? hydrogen1;
		private Hydrogen? hydrogen2;

        public Hydrogen? Hydrogen1 { get => hydrogen1; set => hydrogen1 = value; }
        public Hydrogen? Hydrogen2 { get => hydrogen2; set => hydrogen2 = value; }

        public Oxygen()
		{
		}

		public void React(Hydrogen hydrogen)
		{
			if (this.hydrogen1 == null)
			{
				hydrogen1 = hydrogen;
				return;
			}

			hydrogen2 = hydrogen;
		}

    }
}

