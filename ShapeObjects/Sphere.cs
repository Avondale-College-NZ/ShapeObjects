using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeObjects
{
    class Sphere : Shapes
    {
        public Sphere(int Radius)
        {
            _radius = Radius;
        }

        public new double calcArea()
        {
            return 4 * _PI * Math.Pow(_radius, 2);
        }

        public double calcVolume()
        {
            return 4 * _PI * Math.Pow(_radius, 3) / 3;
        }
    }
}
