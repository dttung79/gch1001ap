using System;
using System.Collections.Generic;

namespace ShapeProject
{
    public class ShapeProgram : MenuProgram
    {
        private List<Shape> shapes;
        
        public ShapeProgram()
        {
            shapes = new List<Shape>();
        }

        protected override void PrintMenu()
        {
            Console.WriteLine("Shape Program");
            Console.WriteLine("1. Add a rectangle");
            Console.WriteLine("2. Add a circle");
            Console.WriteLine("3. Add a square");
            Console.WriteLine("4. Add a triangle");
            Console.WriteLine("5. Show all shapes");
            Console.WriteLine("0. Exit");
        }
        protected override void Process(int choice)
        {
            switch (choice)
            {
                case 1: AddRectangle(); break;
                case 2: AddCircle(); break;
                case 3: AddSquare(); break;
                case 4: AddTriangle(); break;
                case 5: ShowAllShapes(); break;
                case EXIT: break;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
        private void AddRectangle()
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = double.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(name, width, height));
        }
        private void AddCircle()
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            shapes.Add(new Circle(name, radius));
        }
        private void AddSquare()
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the side: ");
            double side = double.Parse(Console.ReadLine());
            Square sq = new Square(name, side);
            shapes.Add(sq);
        }

        private void AddTriangle()
        {
            Console.WriteLine("1. Add a normal triangle");
            Console.WriteLine("2. Add a isoceles triangle");
            Console.WriteLine("3. Add a equilateral triangle");
            Console.WriteLine("0. Back");
            int choice = GetChoice();
            switch (choice)
            {
                case 1: AddNormalTriangle(); break;
                case 2: AddIsocelesTriangle(); break;
                case 3: AddEquilateralTriangle(); break;
                case EXIT: break;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
        private void AddNormalTriangle()
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the side A: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter the side B: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Enter the side C: ");
            double sideC = double.Parse(Console.ReadLine());
            shapes.Add(new NormalTriangle(name, sideA, sideB, sideC));
        }
        private void AddIsocelesTriangle()
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the base: ");
            double baze = double.Parse(Console.ReadLine());
            Console.Write("Enter the side: ");
            double side = double.Parse(Console.ReadLine());
            shapes.Add(new IsoTriangle(name, baze, side));
        }
        private void AddEquilateralTriangle()
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the side: ");
            double side = double.Parse(Console.ReadLine());
            shapes.Add(new EqualTriangle(name, side));
        }
        private void ShowAllShapes()
        {
            foreach (Shape s in shapes)
            {
                s.ShowInfo();
                Console.WriteLine("----------------------");
            }
        }
    }
}