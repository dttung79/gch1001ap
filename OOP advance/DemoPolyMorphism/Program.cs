using DemoPolyMorphism;

// Animal a = new Animal();
// a.Say();

// Dog d = new Dog();
// d.Say();

// Cat c = new Cat();
// c.Say();

Animal[] animals = new Animal[4];
animals[0] = new Animal();
animals[1] = new Dog();
animals[2] = new Cat();
animals[3] = new Animal();

foreach (Animal a in animals)
{
    a.Say();
}