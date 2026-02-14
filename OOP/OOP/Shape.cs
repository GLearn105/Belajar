using System;
namespace OOP
{
    class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            Console.WriteLine("Constructor Rectangle called.");
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            this.Radius = radius;
            Console.WriteLine("Constructor Circle called.");
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}