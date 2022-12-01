using System;

namespace ShapeProject
{
    public class IsoTriangle : NormalTriangle
    {
        public double Base
        {
            get { return SideA; }
            set { SideA = value; }
        }
        public double Side
        {
            get { return SideB; }
            set { SideB = SideC = value; }
        }

        public IsoTriangle() : base("IsoTriangle", 3.0, 2.0, 2.0)
        {
            type = "Isocelese Triangle";
        }
        public IsoTriangle(string name, double baze, double side) : 
                                                base(name, baze, side, side)
        {
            type = "Isocelese Triangle";
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Shape: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Perimeter: " + GetPerimeter());
            Console.WriteLine("Base: " + Base);
            Console.WriteLine("Side: " + Side);
        }
    }
}