namespace Lesson20;
class Program
{
    static void Main(string[] args)
    {
        BaseClass baseClass = new BaseClass("Name 1");

        InheritedClassA inheritedA = new InheritedClassA("Name 2");
        InheritedClassB inheritedB = new InheritedClassB("Name 3");

        baseClass.Print();
        inheritedA.Print();
        inheritedB.Print();

        baseClass = inheritedA;
        //вызывается переопределенный метод
        baseClass.Print();

        baseClass = inheritedB;
        //вызывается метод базового класса
        baseClass.Print();

        //проверяем является ли значение в переменной baseClass InheritedClassB
        if (baseClass is InheritedClassB)
        {
            ((InheritedClassB)baseClass).Print();
            //as - использовать как InheritedClassB
            //приводим переменную базового типа к наследуемому
            (baseClass as InheritedClassB).Print();
        }
    }
}

