using System;

namespace FigureSystem 
{
    public class Triangle : Figure
    {
        public int Height { get; set; }

        public Triangle(int height)
        {
            Height = height;
        }

        public override void Draw()
        {
            for (int i = 1; i <= Height; i++)
            {
                DrawLine(i);
            }
        }
    }
}