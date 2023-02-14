namespace Homework17;
class Program
{
    static void Main(string[] args)
    {
        Hydrogen h1 = new Hydrogen();
        Hydrogen h2 = new Hydrogen();
        Hydrogen h3 = new Hydrogen();
        Hydrogen h4 = new Hydrogen();
        Oxygen o1 = new Oxygen();
        Oxygen o2 = new Oxygen();
        Oxygen o3 = new Oxygen();

        h1.React(o1);
        o2.React(h2);
        o1.React(h3);
        h4.React(o1);
        o3.React(h4);

        Console.WriteLine(IsWater(h4));
        Console.WriteLine(IsWater(o1));
    }

    static bool IsWater(Hydrogen hydrogen)
    {
        if (hydrogen.Oxygen1 != null)
        {
            if (hydrogen.Oxygen1.Hydrogen1 != null && hydrogen.Oxygen1.Hydrogen2 != null)
            {
                if (hydrogen.Oxygen1.Hydrogen1 != hydrogen.Oxygen1.Hydrogen2)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        return false;
    }

    static bool IsWater(Oxygen oxygen)
    {
        if (oxygen.Hydrogen1 != null && oxygen.Hydrogen2 != null)
        {
            if (oxygen.Hydrogen2 != oxygen.Hydrogen1)
            {
                return true;
            }
            return false;
        }
        return false;
    }
}

