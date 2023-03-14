using System;
namespace Lesson21
{
	//можем не реализовывать метод Print(), т.к. у него есть реализация в интерфейсе по умолчанию
	public class Thing : IPrintable
	{
		//статические члены класса являются общими для всех экземпляров (объектов класса)
		//статические поле будет одно для всех экземпляров
		private static int counter;
		public static int Counter { get => counter; }

		private string name;
        public string Name { get => name; set => name = value; }

		public Thing(string name)
		{
			counter++;
			this.name = name;
		}


		//автосвойство - компилятор ввтоматичсеки создаст поле для него
		public int Weight { get; set; }

		//переопределение операторов сравнения
		public static bool operator > (Thing thing1, Thing thing2)
		{
			return thing1.Weight > thing2.Weight;
		}

        public static bool operator < (Thing thing1, Thing thing2)
        {
            return thing1.Weight < thing2.Weight;
        }

        public static bool operator == (Thing thing1, Thing thing2)
        {
            return thing1.Weight == thing2.Weight;
        }

        public static bool operator != (Thing thing1, Thing thing2)
        {
            return thing1.Weight != thing2.Weight;
        }
    }
}

