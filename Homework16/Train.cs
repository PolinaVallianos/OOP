using System;
namespace Homework16
{
	public class Train
	{
		private Carriage? firstCarriage;

		public Train()
		{
		}

		public Carriage? GetCarriage(int number)
		{
			var currentCarriage = firstCarriage;

			for (int i = 1; i < number; i++)
			{
				if (currentCarriage == null)
				{
					break;
				}
				else
				{
					currentCarriage = currentCarriage.Next;
				}
			}

			return currentCarriage;
		}

		public void AddCarriage(Carriage carriage)
		{
			if (firstCarriage == null)
			{
				firstCarriage = carriage;
				return;
			}

			var currentCarriage = firstCarriage;

			while (currentCarriage.Next != null)
			{
                currentCarriage = currentCarriage.Next;
            }

			currentCarriage.Next = carriage;
			//currentCarriage.Next.Prev = currentCarriage;
			carriage.Prev = currentCarriage;
		}

		public void AddCarriage(Carriage carriage, int number)
		{
			var currentCarriage = GetCarriage(number);
			if (currentCarriage == null)
			{
				AddCarriage(carriage);
				return;
			}

			var prevCarriage = currentCarriage.Prev;

			if (prevCarriage != null) prevCarriage.Next = carriage;

			carriage.Prev = prevCarriage;
			carriage.Next = currentCarriage;
			currentCarriage.Prev = carriage;
		}

		public void RemoveCarriage(int number)
		{
			var currentCarriage = GetCarriage(number);
			if (currentCarriage == null) return;

			var nextCarriage = currentCarriage.Next;
			var prevCarriage = currentCarriage.Prev;

			if (nextCarriage != null) nextCarriage = prevCarriage;
			if (prevCarriage != null) prevCarriage = nextCarriage;
		}

		public void Print()
		{
			var currentCarriage = firstCarriage;
			var number = 1;

			while (currentCarriage != null)
			{
				Console.WriteLine($"Carriage {number} - {currentCarriage.Type}");
				currentCarriage = currentCarriage.Next;
				number++;
			}
		}
	}
}

