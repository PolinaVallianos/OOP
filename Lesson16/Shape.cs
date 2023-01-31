using System;
namespace Lesson16
{
	public class Shape
	{
		private int square;
		private Point center;

        public int Square { get => square; set => square = value; }

        public Shape(int x, int y)
		{
			center = new Point();
			center.X = x;
			center.Y = y;

		}

        public class Point
		{
			private int x;
			private int y;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
        }
	}
}

