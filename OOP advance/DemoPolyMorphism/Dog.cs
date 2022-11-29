using System;

namespace DemoPolyMorphism
{
    public class Dog : Animal
    {
        public override void Say()
        {
            Console.WriteLine("Woof!");
        }
    }
}