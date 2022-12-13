using DemoTemplateMethod;
using System;
using System.Collections.Generic;

List<Candidate> candidates = new List<Candidate>();
candidates.Add(new Candidate("John", 30, 8.0));
candidates.Add(new Candidate("Paul", 31, 5.5));
candidates.Add(new Candidate("Mike", 26, 7.5));
candidates.Add(new Candidate("Arthur", 23, 5.0));
candidates.Add(new Candidate("Jerry", 25, 7.0));
candidates.Add(new Candidate("Tom", 35, 8.5));

HRDepartment hr;

System.Console.Write("Choose department: (1) IT, (2) Sales: ");
string answer = Console.ReadLine();
if (answer == "1")
    hr = new ITHRDepartment();
else
    hr = new SaleHRDepartment();
    
List<Employee> employees = hr.Recruit(candidates);
System.Console.WriteLine("Congratulations! You have hired the following employees:");
foreach (Employee e in employees)
{
    System.Console.WriteLine(e);
}

