using System;
namespace Lesson19
{
	//интерфейс определяет способ взаимодействия с объектом
	//публичные свойства и методы без реализации
	public interface IMovable
	{
		public Vector2 Direction { get; set; }
		public void Move();
	}
}

