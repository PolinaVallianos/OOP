using System;
namespace Homework18
{
	public class Flat : Lodging
	{
        public Flat(int numberOfRooms) : base(numberOfRooms)
        {
        }

        public override void GetNumberOfrooms()
        {
            Console.WriteLine($"Has {numberOfRooms} rooms.");
        }

        public virtual void GetSquare()
        {
            Console.WriteLine($"Area: {Lenght * Width} square meters.");
        }


        public override void GetFloor()
        {
            Console.WriteLine($"On the {Floor} floor.");
        }
    }
}

