using System;

namespace DemoPolyMorphism
{
    public class Cat : Animal
    {
        public override void Say()
        {
            Console.WriteLine("Meow!");
        }
    }
}