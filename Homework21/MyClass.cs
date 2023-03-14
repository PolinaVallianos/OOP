using System;
namespace Homework21
{
	public class MyClass : INamed, INumerable, IComparable, IPrint
	{
        public string Name { get => Name; set => Name = value; }
        public int Number { get => Number; set => Number = value; }

        public MyClass()
        {
        }

        public MyClass(int number)
		{
            this.Number = number;
		}


        public void Print()
        {
            Console.WriteLine($"{Number}. {Name}");
        }
    }
}

