using System;
namespace Lesson19
{
	public class Enemy : GameObject, IMovable, IDamageable
	{
		private Vector2 direction;
		private int health;

		public Vector2 Direction { get => direction; set => direction = value; }

		public int Health { get => health; }

		public Enemy(int x, int y, int health) : base(x, y)
		{
			direction = new Vector2(0, 0);
		}
		public void Move()
		{
			Position.X += direction.X;
			Position.Y += direction.Y;

			Console.WriteLine($"{this}/t {Position}");

		}

		public void Damage(int power)
		{
			health -= power;
			Console.WriteLine($"{this}\t Health = {health}");
		}
	} 
}

