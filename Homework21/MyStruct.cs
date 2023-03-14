using System;
namespace Homework21
{
    public struct MyStruct : INamed, INumerable, IComparable, IPrint
    {
        private string description;

        public string Name { get => Name; set => Name = value; }
        public int Number { get => Number; set => Number = value; }
        public string Description { get => description; set => description = value; }

        public MyStruct(int number)
        {
            this.Number = number;
        }

        public void Print()
        {
            Console.WriteLine($"{Number}. {Name}. {Description}");
        }
    }
}

