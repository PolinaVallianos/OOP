using System;
namespace Homework19_20
{
	public interface IPoisonDamagable
	{
        public int Health { get; }

        public void PoisonDamage(int power);
    }
}

