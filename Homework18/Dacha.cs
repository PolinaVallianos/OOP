using System;
namespace Homework18
{
	public class Dacha : Flat
	{
		private int landArea;
        private int placeForCar;

        public int LandArea { get => LandArea; set => LandArea = value; }
        public int PlaceForCar { get => PlaceForCar; set => PlaceForCar = value; }

        public Dacha(int numberOfrooms, int landArea, int placeForCar) : base(numberOfrooms)
        {
            this.landArea = landArea;
            this.placeForCar = placeForCar;
        }

        public override void GetSquare()
        {
            Console.WriteLine($"Area: {Lenght * Width} square meters, and Garden area: {landArea - Lenght * Width} square meters.");
            if (placeForCar != 0)
            {
                if (placeForCar > 1)
                {
                    Console.WriteLine($"There are {placeForCar} places for cars.");
                    return;
                }
                Console.WriteLine($"There is {placeForCar} place for car.");
                return;
            }
            Console.WriteLine($"No places for cars.");

        }

        public override void GetFloor()
        {
            if (Floor > 1)
            {
                Console.WriteLine($"Has {Floor} floors.");
                return;
            }
            Console.WriteLine($"Has {Floor} floor.");
        }
    }
}

