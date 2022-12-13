using System;

namespace FigureSystem
{
    public class Rectangle : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                DrawLine(Width);
            }
        }
    }
}