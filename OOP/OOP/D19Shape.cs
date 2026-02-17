using System;
namespace OOP
{
    abstract class D19Shape
    {
        public string Name { get; set; } = "";
        public abstract double CalculateArea();
    }
    class D19Circle : D19Shape
    {
        public double Radius { get; set; }
        public D19Circle( double radius)
        {
            this.Radius = radius;
            Console.WriteLine("Constructor D19Circle called.");
        }
        public override double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"The area of the circle {Name} is: {area}");
            return area;
        }
    }
    class D19Rectangle : D19Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public D19Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            Console.WriteLine("Constructor D19Rectangle called.");
        }
        public override double CalculateArea()
        {
            double area = Width * Height;
            Console.WriteLine($"The area of the rectangle {Name} is: {area}");
            return area;
        }
    }
}