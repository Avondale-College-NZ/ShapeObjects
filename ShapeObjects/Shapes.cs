using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeObjects
{

    //OOP {Inheritance, Encapsulation, Polymorphism, Abstraction}
    class Shapes
    {
        private int _length; //default = private


        public  int height { get; set; } //auto implemented property 
        public int Length //using accessors
        {
            set
            {
                if(Length <= 0)
                {
                    throw new Exception("Length cannot be negative or 0");
                }
                _length = value;
            }

            get
            {
                return _length;
            }
        }

        //public void SetLength(int Length) //set Method = write to
        //{
        //    _length = Length;
        //}
        //public int GetLength() // get Methods = Read from
        //{
        //    return _length;
        //}   
         
        private int _width;

        public void SetWidth(int Width) //set Method = write to
        {
            _width = Width;
        }
        public int GetWidth() // get Methods = Read from
        {
            return _width;
        }


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
            //
            SetWidth(Width);
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
