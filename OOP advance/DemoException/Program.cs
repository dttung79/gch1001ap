using System;

// try
// {
//     System.Console.WriteLine("Enter a: ");
//     int a = int.Parse(Console.ReadLine());
//     System.Console.WriteLine("Enter b: ");
//     int b = int.Parse(Console.ReadLine());
//     int c = a / b;
//     System.Console.WriteLine("Result: " + c);
// } 
// catch (FormatException)
// {
//     System.Console.WriteLine("Invalid input");
// }
// catch (DivideByZeroException)
// {
//     System.Console.WriteLine("Divide by zero");
// }
try 
{
    Console.Write("Enter length of array: ");
    int n = int.Parse(Console.ReadLine());

    int[] a = new int[n];
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write("Enter a[{0}]: ", i);
        a[i] = int.Parse(Console.ReadLine());
        sum += a[i];
    }
    Console.Write("Enter lower: "); int lower = int.Parse(Console.ReadLine());
    Console.Write("Enter upper: "); int upper = int.Parse(Console.ReadLine());
    int partialSum = 0;
    for (int i = lower; i <= upper; i++)
    {
        partialSum += a[i];
    }

    double rate = (double) partialSum / sum;
    System.Console.WriteLine("Rate: " + rate);
} 
catch (FormatException)
{
    System.Console.WriteLine("Invalid input");
}
catch (IndexOutOfRangeException)
{
    System.Console.WriteLine("Index out of range");
}
catch (DivideByZeroException)
{
    System.Console.WriteLine("Divide by zero");
}