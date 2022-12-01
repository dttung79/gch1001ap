using System;

namespace ShapeProject
{
    public class NormalTriangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public NormalTriangle() : base("NormalTriangle")
        {
            SideA = 3.0;
            SideB = 4.0;
            SideC = 5.0;
            type = "NormalTriangle";
        }
        public NormalTriangle(string name, double sideA, 
                                           double sideB, 
                                           double sideC) : base(name)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            type = "NormalTriangle";
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Side A: " + SideA);
            Console.WriteLine("Side B: " + SideB);
            Console.WriteLine("Side C: " + SideC);
        }
    }
}