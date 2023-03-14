using System;
namespace Homework21
{
    public interface IComparable : INumerable
	{
        public static bool operator >(INumerable number1, INumerable number2)
        {
            return number1.Number > number2.Number;
        }

        public static bool operator <(INumerable number1, INumerable number2)
        {
            return number1.Number < number2.Number;
        }
    }
}

