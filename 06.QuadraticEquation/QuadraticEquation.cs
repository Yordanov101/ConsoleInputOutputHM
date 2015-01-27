using System;
class QuadraticEquation
{
    // Write a program that reads the coefficients a, b and c of a quadratic equation 
    // ax2 + bx + c = 0 and solves it (prints its real roots).
    // Example : a=2,	b=5,	c= -3,	roots= x1=-3; x2=0.5  .
    static void Main()
    {
        Console.Write("Enter coefficient (a) : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient (b): ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient (c): ");
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - 4 * a * c;
        if (d < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else
        {
            double onlyRoot = Math.Sqrt(d);
            double x1 = (-b + onlyRoot) / (2 * a);
            double x2 = (-b - onlyRoot) / (2 * a);
            Console.WriteLine(x1 == x2 ? "The Equasion got one real root {0}" : "The Equasion got two real roots {0} and {1}", x1, x2);
        }
    }
}
