using System;
namespace Lesson19
{
	public interface IDamageable
	{
		public int Health { get; }

		public void Damage(int power);
	}
}

