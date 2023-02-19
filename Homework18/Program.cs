namespace Homework18;
class Program
{
    static void Main(string[] args)
    {
        Flat flat = new Flat(3);
        Dacha dacha = new Dacha(7, 120, 0);
        Apartment apartment = new Apartment(5, 32);

        SetLodging(flat, 10, 4, 7);
        SetLodging(dacha, 15, 5, 3);
        SetLodging(apartment, 10, 8, 12);

        Console.WriteLine("Flat");
        flat.GetSquare();
        flat.GetNumberOfrooms();
        flat.GetFloor();

        Console.WriteLine("\nDacha");
        dacha.GetSquare();
        dacha.GetNumberOfrooms();
        dacha.GetFloor();

        Console.WriteLine("\nApartment");
        apartment.GetSquare();
        apartment.GetNumberOfrooms();
        apartment.GetFloor();
    }

    static void SetLodging(Lodging lodging, int lenght, int width, int floor)
    {
        lodging.Lenght = lenght;
        lodging.Width = width;
        lodging.Floor = floor;
    }
}

