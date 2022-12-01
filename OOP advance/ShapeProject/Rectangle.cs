using System;

namespace ShapeProject
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() : base("Rectangle")
        {
            Width = 3.0;
            Height = 2.0;
        }
        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
        }
    }
}