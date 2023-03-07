using System;
namespace Lesson19
{
	public class Enemy : GameObject, IMovable, IDamageable, ICollidable
	{
		private Vector2 direction;
		private int health;

		public Vector2 Direction { get => direction; set => direction = value; }

		public int Health { get => health; }

		public Enemy(int x, int y, int health) : base(x, y)
		{
			direction = new Vector2(0, 0);
			this.health = health;
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

        public void Collide(GameObject obstacle)
        {
			if (obstacle is Wall && Position.X == obstacle.Position.X && Position.Y == obstacle.Position.Y)
			{
				Console.WriteLine($"");
				direction.X = -direction.X;
				direction.Y = -direction.Y;

				
			}
        }
    } 
}

