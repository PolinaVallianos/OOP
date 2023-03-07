using System;
namespace Lesson21
{
    //структура - это значимый тип
    //структуры не поддерживают наследованиеб но могут реальзовывать интерфейсы
    public struct Person : IPrintable
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        //структура всегда содержит скрытый конструктор без параметров
        //который инициализирует все поля значениями по умолчанию

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //заменяем реализацию по умолчанию интерфейса IPrintable
        public void Print()
        {
            Console.WriteLine($"Name - {Name}, Age - {Age}");
        }
    }
}

