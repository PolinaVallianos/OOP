using System;
using Homework16;

namespace Homework16a
{
    public enum Carriagetype2
    {
        Coupe,
        Lux,
        Restaurant
    }

    public class Carriage2
    {
        private Carriagetype2 type;
        private Carriage2? next;
        private Carriage2? prev;

        public Carriagetype2 Type { get => type; }
        public Carriage2? Next
        {
            get => next;
            set
            {
                next = value;

                if (value != null && value.Prev != this) value.Prev = this;
            }
        }

        public Carriage2? Prev
        {
            get => prev;
            set
            {
                prev = value;

                if (value != null && value.Next != this) value.Next = this;
            }
        }

        public Carriage2(Carriagetype2 restaurant)
        {
            this.type = type;
        }
    }
}

