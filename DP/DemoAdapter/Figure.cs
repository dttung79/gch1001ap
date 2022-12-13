using System;

namespace FigureSystem
{
    public abstract class Figure
    {
        public abstract void Draw();
        protected void DrawLine(int n)
        {
            for (int i = 0; i < n; i++) Console.Write("*");
            Console.WriteLine();
        }
    }
}