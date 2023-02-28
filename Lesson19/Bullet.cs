
namespace Lesson19
{
	public class Bullet : GameObject, IMovable, ICollidable
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

		public void Collide(GameObject ob)
		{
			if (Position.X == ob.Position.X && Position.Y == ob.Position.Y)
			{
				Console.WriteLine($"{this}\t Collision with {ob}");

				//оператор is проверяет, представляет ли значение определенный тип либо интерфейс
				if (ob is IDamageable)
				{
                    //приводим объект типа GameObject к интерфейсу IDamageable
                    Attack((IDamageable)ob);
					Rebound();
				}

				else
				{
					Rebound();
				}
			}
		}

		//отскок - изменение направления на противвоположный
		private void Rebound()
		{
			direction.X = -direction.X;
			direction.Y = -direction.Y;
		}
    }
}

