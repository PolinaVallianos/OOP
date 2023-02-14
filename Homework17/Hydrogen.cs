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
            if (this.oxygen1 != null)
            {
                return;
            }
            if (oxygen.Hydrogen1 == null)
            {
                oxygen.Hydrogen1 = this; //h1.React(o1), h1 - this
                this.oxygen1 = oxygen;
                return;
            }
            if (oxygen.Hydrogen2 == null)
            {
                oxygen.Hydrogen2 = this;
                this.oxygen1 = oxygen;
            }

        }
    }
}

