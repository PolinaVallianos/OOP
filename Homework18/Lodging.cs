using System;
namespace Homework18
{
	public abstract class Lodging
	{
		protected int numberOfRooms;
		private int lenght;
		private int width;
		private int floor;

        public int Lenght { get => lenght; set => lenght = value; }
        public int Width { get => width; set => width = value; }
        public int Floor { get => floor; set => floor = value; }

        public Lodging(int numberOfrooms)
		{
			this.numberOfRooms = numberOfrooms;
		}


        public abstract void GetNumberOfrooms();
        public abstract void GetFloor();
    }
}

