using System;
namespace Homework19_20
{
    public class Worm : GameObject, IMoveble
	{
        private Vector2 direction;
        private int health;

        public Vector2 Direction { get => direction; set => direction = value; }

        public int Health { get => health; }

        public Worm(int x, int y, int health) : base(x, y)
        {
            direction = new Vector2(0, 0);
            this.health = health;
        }
        public void Move()
        {
            if (Position.X < 16)
            {
                Position.X += direction.X;
            }
            else
            {
                Position.Y += direction.Y;
                Position.X -= direction.X;
            }

            if (Position.X == 16 && Position.Y == 16)
            {
                Position.Y = 1;
                Position.X = 1;
            }

            Console.WriteLine($"{this}/t {Position}");

        }

        public void PoisonDamage(int power)
        {
            health -= power;
            Console.WriteLine($"{this}\t Health = {health}");
        }

        public void Heal(int power)
        {
            health += power;
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

