using System;

namespace ShapeProject
{
    public class EqualTriangle : IsoTriangle
    {
        public double Side
        {
            get { return SideA; }
            set { SideA = SideB = SideC = value; }
        }

        public EqualTriangle() : base("EqualTriangle", 3.0, 3.0)
        {
            type = "Equilateral Triangle";
        }
        public EqualTriangle(string name, double side) : 
                                            base(name, side, side)
        {
            type = "Equilateral Triangle";
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Shape: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Perimeter: " + GetPerimeter());
            Console.WriteLine("Side: " + Side);
        }
    }
}