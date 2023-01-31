using System;
namespace Homework16
{
    public class PersonTree
    {
        private string name;

        private PersonTree perent1;
        private PersonTree perent2;

        public PersonTree(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public PersonTree Perent1
        {
            get => perent1;
            set
            {
                if (value == this)
                {
                    Console.WriteLine($"{this.Name} can't be his perent");
                    return;
                }
                if (value != null && value == perent2)
                {
                    Console.WriteLine($"{value.Name} has already been his father");
                    return;
                }
                perent1 = value;
            }
        }

        public PersonTree Perent2 { get => perent2; set => perent2 = value; }
    }
}

