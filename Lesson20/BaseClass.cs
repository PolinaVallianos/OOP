using System;
namespace Lesson20
{
	public class BaseClass
	{
		private string name;
        public string Name { get => name; set => name = value; }

		public BaseClass(string name)
		{
			this.name = name;
		}

		protected void WhoAmI()
		{
			Console.Write($"I am {name}. ");
		}

		public virtual void Print()
		{
			WhoAmI();
			Console.WriteLine("BaseClass");
		}
    }
}

