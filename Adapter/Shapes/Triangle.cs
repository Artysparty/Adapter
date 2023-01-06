using System;
namespace Adapter.Shapes
{
    public class Triangle : IShape
    {
        public float sideA { get; set; }
        public float sideB { get; set; }
        public float sideC { get; set; }
        public float h { get; set; }

        public Triangle(float sideA, float sideB, float sideC, float h)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            this.h = h;
        }

        public float Square()
        {
            return 0.5f * sideB * h;
        }

        public float Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public void Draw()
        {
            Console.WriteLine("Triangle");
        }
    }
}

