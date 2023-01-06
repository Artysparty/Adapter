using System;
namespace Adapter.Shapes
{
	public class Rectangle : IShape
	{
		public float side { get; set; }

        public Rectangle(float side)
		{
			this.side = side;
		}

        public float Square()
        {
			return (float)Math.Pow(side, 2);
        }

		public float Perimeter()
		{
			return (side * 4);
		}

        public void Draw()
		{
			Console.WriteLine("Rectangle");
		}
	}
}

