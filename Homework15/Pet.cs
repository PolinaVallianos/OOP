using System;
namespace Homework15
{
	public enum PetType
	{
		Cat,
		Dog
	}

	public class Pet
	{
		private PetType type;
		private string name;
		private float weight;

        public string Name { get => name; set => name = value; }
        public float Weight { get => weight; set => weight = value; }
        internal PetType Type { get => type; }

        public Pet(string name, PetType type, float weight)
		{
			this.name = name;
			this.type = type;
			this.weight = weight;
		}

        public Pet(string name, PetType type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
