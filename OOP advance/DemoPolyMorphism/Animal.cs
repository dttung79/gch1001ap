using System;

namespace DemoPolyMorphism
{
    public class Animal
    {
        public virtual void Say()
        {
            Console.WriteLine("...");
        }
    }
}