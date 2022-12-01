using System;

namespace ShapeProject
{
    public class Square : Rectangle
    {
        public double Side
        {
            get { return Width; }
            set { Width = Height = value; }
        }

        public Square() : base("Square", 1.0, 1.0)
        {
        }

        public Square(string name, double side) : base(name, side, side)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Shape: " + Name);
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Perimeter: " + GetPerimeter());
            Console.WriteLine("Side: " + Side);
        }
    }
}