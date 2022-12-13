using System;
using TextSystem;

namespace FigureSystem
{
    public class TextFigure : Figure
    {
        private TextBox textBox;
        public TextFigure(string text)
        {
            textBox = new TextBox(text);
        }
        public override void Draw()
        {
            textBox.Print();
        }
    }
}