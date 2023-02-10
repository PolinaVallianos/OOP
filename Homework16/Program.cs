namespace Homework16;
class Program
{
    static void Main(string[] args)
    {
        Carriage carriageRest = new Carriage(Carriagetype.Restaurant);
        Carriage carriageCoupe = new Carriage(Carriagetype.Coupe);
        Carriage carriageLux = new Carriage(Carriagetype.Lux);

        Train train = new Train();

        for (int i = 0; i < 5; i++)
        {
            train.AddCarriage(new Carriage(Carriagetype.Coupe));
        }

        train.AddCarriage(carriageLux, 4);
        train.RemoveCarriage(2);

        ChageCarriage(train.GetCarriage(2), carriageRest);
        ChageCarriage(train.GetCarriage(7), new Carriage(Carriagetype.Restaurant);
        train.Print();
    }

    static void ChageCarriage(Carriage? oldC, Carriage? newC)
    {
        if (oldC == null || newC == null) return;

        var prevC = oldC.Prev;
        var nextC = oldC.Next;

        newC.Prev = prevC;
        newC.Next = nextC;

        if (nextC != null) nextC.Prev = newC;
        if (prevC != null) prevC.Prev = newC;
    }
}

