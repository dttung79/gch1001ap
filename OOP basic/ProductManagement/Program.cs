using ProductManagement;

Product computer = new Product("HP", 1000);
System.Console.WriteLine(computer.Count);  // -> 1
Product p = new Product();
System.Console.WriteLine(computer.Count);  // -> 2
System.Console.WriteLine(p.Count);         // -> 2