using System;
namespace Adapter.Shapes
{
	public class Circle : IShape
	{
		public float radius { get; set; }

		public Circle(float radius)
		{
			this.radius = radius;
		}

		public float Square()
		{
            return (float)Math.Pow(3.14 * radius, 2);
        }

        public float Perimeter()
        {
            return 2 * 3.14f * radius;
        }

        public void Draw()
		{
			Console.WriteLine("Circle");
		}
	}
}

