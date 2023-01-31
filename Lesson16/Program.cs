using Homework16;

namespace Lesson16;
class Program
{
    static void Main(string[] args)
    {
        PersonTree petya = new PersonTree("Petya");
        //ссылочные переменные представляют ссылку на объект
        //null - это отсутсвие ссылки на объект

        if (petya.Perent1 != null)
        {
            Console.WriteLine($"{petya.Perent1.Name} is {petya.Name}'s perent");
        }

        //вопросительный знак значит, что значение name вернется, то если Perent1 не равен null
        //если Parent == null то вернется null
        Console.WriteLine($"{petya.Perent1?.Name} is {petya.Name}'s perent");

        string perent = petya.Perent1?.Name;
        Console.WriteLine(perent?.Length);

        PersonTree mike = new PersonTree("Mike");
        PersonTree kate = new PersonTree("Kate");
        petya.Perent1 = mike;
        petya.Perent2 = kate;

        Console.WriteLine($"{petya.Perent1?.Name} is {petya.Name}'s perent");
        Console.WriteLine($"{petya.Perent2?.Name} is {petya.Name}'s perent");

        PersonTree sophia = new PersonTree("Sophia");
        sophia.Perent1 = mike;
        sophia.Perent2 = kate;

        //если мы сравниваем ссылочные переменные, то провверяется то, что они ссылаются на один объект
        if (petya.Perent1 == sophia.Perent1)
        {
            Console.WriteLine($"{petya.Name} and {sophia.Name} are family");
        }

        sophia.Perent1.Name = "Bob";
        Console.WriteLine($"{petya.Perent1?.Name} is {petya.Name}'s perent");

        Rename(sophia, "Nina");
        Console.WriteLine($"{sophia.Name}");

        petya = mike;

        CheckPerents(petya, ref mike);
        Console.WriteLine($"{petya.Name} - {mike?.Name}");

        petya.Perent1 = petya;

    }

    //в метод передается ссылка на объект и его внутренние данные можно изменить
    static void Rename(PersonTree person, string name)
    {
        person.Name = name;
    }

    static void CheckPerents(PersonTree perent1, ref PersonTree? perent2)
    {
        if (perent1 == perent2)
        {
            perent2 = null;
        }
    }
}

