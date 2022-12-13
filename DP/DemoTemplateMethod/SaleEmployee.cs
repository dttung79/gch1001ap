using System;

namespace DemoTemplateMethod
{
    public class SaleEmployee : Employee
    {
        public int Products { get; set; }
        public SaleEmployee(string name, int age, 
                    double salary, int products) : base(name, age, salary)
        {
            Products = products;
        }
        public override string ToString()
        {
            return string.Format("Sale Name: {0}, Age: {1}, Salary: {2}, Products: {3}", 
                Name, Age, Salary, Products);
        }
    }
}