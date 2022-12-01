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
            Console.WriteLine("3. Show all shapes");
            Console.WriteLine("0. Exit");
        }
        protected override void Process(int choice)
        {
            switch (choice)
            {
                case 1: AddRectangle(); break;
                case 2: AddCircle(); break;
                case 3: AddSquare(); break;
                case 4: ShowAllShapes(); break;
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