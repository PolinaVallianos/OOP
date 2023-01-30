namespace Homework15;
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Polina", 15);
        person1.AddPet(new Pet("Pusheen", PetType.Cat, 5));
        person1.AddPet(new Pet("Rambo", PetType.Dog));

        PrintInfo(person1);

        Person person2 = new Person("Vlad", 21);
        person2.AddPet(new Pet("Kaktus", PetType.Cat, 6));
        person2.RemovePet("Kaktus");

        PrintInfo(person2);
    }

    static void PrintInfo(Person person)
    {
        Console.WriteLine($"{person.Name}, {person.Age} years." +
            $"Has {person.NumberOfPets} pets");

        float weightOfAllPets = 0;
        int count = 0;

        if (person.NumberOfPets == 0)
        {
            Console.WriteLine("Total weight: 0 kg.");
        }

        else
        {
            for (int i = 0; i < person.NumberOfPets; i++)
            {
                if (person.Pets[i].Weight == 0)
                {
                    Console.WriteLine($"{i + 1} - {person.Pets[i].Type}" +
                        $"{person.Pets[i].Name}, weight is unknown.");
                    count++;
                }

                else
                {
                    Console.WriteLine($"{i + 1} - {person.Pets[i].Type}" +
                        $"{person.Pets[i].Name}, {person.Pets[i].Weight} kg.");
                    weightOfAllPets =+ person.Pets[i].Weight;
                }
                
            }

            if (count == person.NumberOfPets)
            {
                Console.WriteLine("Total weight: unknown.\n");
            }

            else
            {
                Console.WriteLine($"Total weight: {weightOfAllPets} kg.\n");
            }
        }
    }
}
