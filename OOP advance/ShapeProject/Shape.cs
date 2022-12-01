using System;

namespace ShapeProject
{
    public abstract class Shape
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Shape()
        {
            name = "Shape";
        }
        public Shape(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public virtual void ShowInfo()
        {
            Console.WriteLine("Shape: " + Name);
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Perimeter: " + GetPerimeter());
        }
    }
}