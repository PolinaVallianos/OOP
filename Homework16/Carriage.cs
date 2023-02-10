using System;
namespace Homework16
{
	public enum Carriagetype
	{
		Coupe,
		Lux,
		Restaurant
	}

	public class Carriage
	{
		private Carriagetype type;
		private Carriage? next;
		private Carriage? prev;

        public Carriagetype Type { get => type; }
        public Carriage? Next { get => next; set => next = value; }
        public Carriage? Prev { get => prev; set => prev = value; }

        public Carriage(Carriagetype restaurant)
		{
			this.type = type;
		}
    }
}

