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
        protected string type;
        public string Type
        {
            get { return type; }
        }
        public Shape()
        {
            name = "Shape";
            type = "Shape";
        }
        public Shape(string name)
        {
            Name = name;
            type = "Shape";
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