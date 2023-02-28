using System;
namespace Lesson20
{
    public class InheritedClassA : BaseClass
    {
        public InheritedClassA(string name) : base(name)
        {
        }

        public override void Print()
        {
            WhoAmI();
            Console.WriteLine($"InheritedA");
        }
    }

    public class InheritedClassB : BaseClass
    {
        public InheritedClassB(string name) : base(name)
        {
        }

        //скрываем метод базового класса с помощью слова new
        private new void WhoAmI()
        {
            Console.WriteLine("I am InheritedB. ");
        }

        //скрываем виртуальный метод базового класса
        public new void Print()
        {
            //можно получить доступ к скрытому методу с помощью base
            base.WhoAmI();
            WhoAmI();
        }
    }
}

