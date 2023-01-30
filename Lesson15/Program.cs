namespace Lesson15;

//OOP:
// - абстракция
// - инкапсуляция
// - наследование
// - полиморфизм
class Program
{
    static void Main(string[] args)
    {
        //объект это экземпляр класса
        //для создания объекта вызывается конструктор класса после слова "new"
        MyClass myClass = new MyClass();
        MyClass myClass1 = new MyClass("Class1");

        //задаем свойство объекта myClass1
        myClass1.Number = 12;
        //получаем свойства
        string nameOfClass1 = myClass.Name;

        myClass.Print();
        myClass1.Print();

        Library libary = new Library("Blok", 13);
        Book book = new Book("Homer", "Iliad", 333);

        Library library1 = libary; //такая же ссылка

        libary.AddNewBook(book);
        libary.AddNewBook(new Book("Poul", "Tom & Gek", 312));
        libary.AddNewBook(new Book("Homer", "Odyssey", 564));
        libary.AddNewBook(new Book("Adams", "Tommy", 234));

        libary.FindByTitle("Tom");

        if (libary.GetBook(1, ref book))
        {
            Console.WriteLine(book.Library.Name);
            Console.WriteLine(book.GetInfo());
        }

    }
}

//class - структура данных, объединяющие поля(данные) и методы
//class - определение (или шаблон) для экзэмпляра класса (объектов)

public class MyClass
{
    //поля - данные класса
    private string name = "NewClass"; //значение по умолчанию
    private int number;

    //свойтсва - методы для доступа к полям класса
    public string Name { get => name; set => name = value; }
    public int Number { get => number; set => number = value; }

    //конструктор - метод для создания экземпояра класса
    //конструкторов может быть много(перегрузка методов)

    public MyClass()
    {

    }

    public MyClass(string newName)
    {
        name = newName;
    }

    public MyClass(string newName, int number)
    {
        name = newName;
        //this - ссылка на текущий класс
        this.number = number;
    }

    //методы класса
    public void Print()
    {
        Console.WriteLine($"Class {name} number {number}");
    }
}
