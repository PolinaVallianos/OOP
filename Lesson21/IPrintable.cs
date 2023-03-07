using System;
namespace Lesson21
{
	//интерфейсы могуут наследоваться от других интерфейсов
	public interface IPrintable : INamed
	{
		//реализация метода по умолчанию (начиная с c# 8.0)
		public void Print()
		{
			Console.WriteLine($"Name - {Name}");
		}
	}
}

