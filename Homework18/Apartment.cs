using System;
namespace Homework18
{
    public class Apartment : Flat
    {
        private int squareSwimmingpool;

        public int SquareSwimmingpool { get => squareSwimmingpool; set => squareSwimmingpool = value; }

        public Apartment(int numberOfRooms, int squareSwimmingpool) : base(numberOfRooms)
        {
            this.squareSwimmingpool = squareSwimmingpool;
        }

        public override void GetSquare()
        {
            Console.WriteLine($"Area: {Lenght * Width} square meters and {squareSwimmingpool} square meters of swimmingpool.");

        }

        public override void GetFloor()
        {
            base.GetFloor();
        }
    }
}

