using System;

namespace ShapeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n\n");

            Rectangle R1 = new Rectangle(2, 2);
            Console.WriteLine("The area of rectangle 1 is : {0}", R1.calcArea());

            Circle C1 = new Circle(1);
            Console.WriteLine("The area of the circle 1 is : {0}", C1.calcArea());

            Sphere S1 = new Sphere(1);
            Console.WriteLine("The area of the sphere 1 is : {0}", Math.Round(S1.calcArea(),2));

            Sphere S2 = new Sphere(2);
            Console.Write("\nEnter the Radius of the Sphere: ");
            while(!int.TryParse(Console.ReadLine(), out S2._radius) || S2._radius == 0)
            {
                Console.Write("\nPlease enter a valid number for Radius not equal to 0:  ");
            }                        
            Console.WriteLine("The area of the sphere 2 is : {0}", Math.Round(S2.calcArea(), 2));
            Console.WriteLine("The volume of the sphere 2 is : {0}", Math.Round(S2.calcVolume(), 2));

        }
    }
}
