using System;
namespace Homework19_20
{
	public interface IHealable
	{
		public int Health { get; }

        public void Healing(int power);
    }
}

