using System;
namespace Homework15
{
	public class Person
	{
        const int MaxNumberOfPets = 5;
        private string name;
        private int age;
        private Pet[] pets;
        private int numberOfPets;

        public string Name { get => name; }
        public int Age { get => age; }
        public Pet[] Pets { get => pets; private set => pets = value; }

        //модификатор доступа можно задат отдельно для set или get
        public int NumberOfPets { get => numberOfPets;
            private set => numberOfPets = value; }

        public Person(string name, int age)
		{
            this.name = name;
            this.age = age;
            Pets = new Pet[MaxNumberOfPets];
        }

        public void AddPet(Pet pet)
        {
            if (NumberOfPets < MaxNumberOfPets)
            {
                Pets[NumberOfPets] = pet;
                NumberOfPets++;
            }
        }

        public void RemovePet(string name)
        {
            Pet[] newPets = new Pet[MaxNumberOfPets];
            int index = 0;
            for (int i = 0; i < MaxNumberOfPets; i++)
            {
                if (Pets[i].Name.ToLower().Contains(name.ToLower()))
                {
                    NumberOfPets--;
                    continue;
                }
                newPets[index] = Pets[i];
                index++;
            }

            Pets = newPets;
        }

        public Pet[] GetAllPets()
        {
            Pet[] result = new Pet[NumberOfPets];
            for (int i = 0; i < NumberOfPets; i++)
            {
                result[i] = Pets[i];
            }
            return result;
        }
	}
}

