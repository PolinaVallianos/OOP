using System;
namespace Homework19_20
{
    public class Apple : GameObject
	{
		private int power;

		public Apple(int x, int y, int power) : base(x, y)
		{
			this.power = power;
		}
	}
}

