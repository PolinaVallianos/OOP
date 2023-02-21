
namespace Lesson19
{
	public class Bullet : GameObject, IMovable
	{
		private Vector2 direction;
		private int power;

		public Vector2 Direction { get => direction; set => direction = value; }

		public Bullet(int x, int y, int power, Vector2 direction) : base(x, y)
		{
			this.power = power;
			this.direction = direction;
		}

		public void Move()
		{
			Position.X += direction.X;
			Position.Y += direction.Y;

			Console.WriteLine($"{this}/t {Position}");
        }

		public void Attack(IDamageable target)
		{
			target.Damage(power);
		}
    }
}

