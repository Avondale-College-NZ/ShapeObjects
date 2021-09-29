using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeObjects
{

    //OOP {Inheritance, Encapsulation, Polymorphism, Asbtraction}
    class Shapes
    {
        private int _length; //default = private

        public void SetLength(int Length)
        {
            _length = Length;
        }

        public int GetLength()
        {
            return _length;
        }   
         
        public int _width;


        //public int _height;
        public int _radius;

        public static double _PI = 3.1415962;     //static variable  
        
        
        public virtual int calcArea()
        {
            return _length * _width;    
        }

        public void print()
        {
            Console.WriteLine("Value of PI is : {0}", _PI);
        }
    }

    class Rectangle : Shapes //inherits everything from the Shapes class
    {
        public Rectangle(int Length, int Width)
        {
            SetLength(Length);
            _width = Width;
        }
    }

    class Circle : Shapes
    {
        public Circle(int Radius)
        {
            _radius = Radius;
        }

        public new double calcArea()
        {
            return _radius * _radius * _PI; 
        }
    }    
}
