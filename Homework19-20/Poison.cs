using System;
namespace Homework19_20
{
    public class Poison : GameObject
	{
		private int power;

		public Poison(int x, int y, int power) : base(x, y)
		{
			this.power = power;
		}
	}
}

