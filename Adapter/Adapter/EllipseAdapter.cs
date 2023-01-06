using System;
using Adapter.Shapes;

namespace Adapter.Adapter
{
	public class EllipseAdapter : IShape
	{

        Ellipse ellipse;

        public EllipseAdapter(Ellipse ellipse)
		{
            this.ellipse = ellipse;
        }

        public float Perimeter()
        {
            return (float)((2 * 3.14) * (Math.Sqrt((Math.Pow(2 * ellipse.BigSemiaxis, 2) + Math.Pow(2 * ellipse.SmallSemiaxis, 2)) / 8)));
        }

        public float Square()
        {
            return (float)(3.14 * ellipse.BigSemiaxis * ellipse.SmallSemiaxis);
        }

        public void Draw()
        {
            ellipse.Calculate();
            ellipse.Apply();
        }
    }
}

