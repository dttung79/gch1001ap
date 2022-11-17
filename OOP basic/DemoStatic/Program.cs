using DemoStatic;

Student john = new Student("John", 20);
Student paul = new Student("Paul", 21);

john.ShowInfo();
paul.ShowInfo();

Student.School = "Greenwich Vietnam";
john.ShowInfo();
paul.ShowInfo();