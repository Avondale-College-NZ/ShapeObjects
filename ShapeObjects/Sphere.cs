using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeObjects
{
    class Sphere : Circle
    {
        public Sphere(int Radius) : base(Radius)
        {
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
    
    class Ball : Sphere
    {
       public Ball(int Radius) : base(Radius)
       {            
       }
    }
}
