using System;

namespace ShapeProject
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() : base("Circle")
        {
            Radius = 1.0;
            type = "Circle";
        }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
            type = "Circle";
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Radius: " + Radius);
        }
    }
}