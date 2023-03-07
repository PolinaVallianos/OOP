namespace Lesson21;
class Program
{
    static void Main(string[] args)
    {
        Thing thing = new Thing("pen");
        //можем сохранить объект типа Thing в переменные типа IPrintable
        IPrintable printable = new Thing("pencil");
        //и INamed, благодаря наслдеованию интерфейсу
        INamed named = new Thing("table");

        //статические члены вызываются от имени класса, а не объекта
        Console.WriteLine("Total number: " + Thing.Counter);

        thing.Weight = 10;
        Thing thing2 = (Thing)printable;
        Thing thing3 = (Thing)named;
        thing2.Weight = 10;
        thing3.Weight = 10000;

        //используется переопределенный оператор и сравнивает вес
        if (thing == thing2)
        {
            Console.WriteLine("The weight is equals");
        }

        //сравниваем сслыки (ссылаются ли на один объект)
        Console.WriteLine(thing.Equals(thing2));

        Console.WriteLine(thing3 > thing2);


        Console.WriteLine("\n//------Структуры------//\n");

        //ввызывается конструктор по умолчанию
        Person peter = new Person();

        Console.WriteLine("Name - " + peter.Name);
        Console.WriteLine("Name - " + peter.Age);

        peter.Name = "Peter";
        peter.Age = 20;

        Console.WriteLine("\nName - " + peter.Name);
        Console.WriteLine("Name - " + peter.Age);

        //при присваивании одно структуры другой, копируются все данные
        Person ivan = peter;
        Console.WriteLine("\nName - " + ivan.Name);
        Console.WriteLine("Name - " + ivan.Age);

        //при этого при измененнии одной структуры, данные другой не меняются, в отличии от классов
        ivan.Name = "Ivan";
        ivan.Age = 22;
        Console.WriteLine("\nName - " + peter.Name);
        Console.WriteLine("Name - " + peter.Age);

        //вызываем свой конструктор 
        Person ivan2 = new Person("Ivan", 23);

        //инициализатор - позволяет инициализировать публичные данные в структурах и классах
        Person ivan3 = new Person { Name = "Ivan"};
        Person ivan4 = new Person { Name = "Ivan4", Age = 19};

        //метод Equals - сравненивает; true, усли все данные структур равны
        Console.WriteLine(ivan.Equals(ivan2));
        //в классах он возращает; true, если переменные ссылаются на один объект

        //создание на основе другой с изменениями 
        Person ivan5 = ivan4 with { Age = 25 };
        ivan5.Print();

        SetName(ivan5);
        ivan5.Print();
        SetName(ref ivan5);
        ivan5.Print();

    }

    //при передачи в метод структура копируется
    static void SetName(Person person)
    {
        //здесь мы рабоатем с копией и изменения не влияют на исходную структуру
        person.Name = "New Name";
    }
    //при использования ref, in, out передается ссылка на оригинальную структуру
    static void SetName(ref Person person)
    {
        //теперь мы работаем с оригинальой версией и изменения сохраняются
        person.Name = "Vanya";
    }
}

