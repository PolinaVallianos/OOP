using System;
namespace Homework15
{
	public class Person
	{
        private string name;
        private int age;
        private Pet[] pets;
        private int numberOfPets;

        public string Name { get => name; }
        public int Age { get => age; }
        public Pet[] Pets { get => pets; set => pets = value; }
        public int NumberOfPets { get => numberOfPets;
            set => numberOfPets = value; }

        public Person(string name, int age)
		{
            this.name = name;
            this.age = age;
            Pets = new Pet[5];
        }

        public void AddPet(Pet pet)
        {
            if (NumberOfPets < 5)
            {
                Pets[NumberOfPets] = pet;
                NumberOfPets++;
            }
        }

        public void RemovePet(string name)
        {
            Pet[] newPets = new Pet[NumberOfPets];
            int index = 0;
            for (int i = 0; i < NumberOfPets; i++)
            {
                if (Pets[i].Name.ToLower().Contains(name.ToLower()))
                {
                    continue;
                }
                else
                {
                    newPets[index] = Pets[i];
                    index++;
                }
            }

            Pets = newPets;
            NumberOfPets = newPets.Length;
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

