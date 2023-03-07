using System;
namespace Homework19_20
{
	public interface IMoveble
	{
        public Vector2 Direction { get; set; }
        public void Move();
    }
}

