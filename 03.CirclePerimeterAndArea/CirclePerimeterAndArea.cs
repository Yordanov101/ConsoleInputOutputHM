using System;
using System.Globalization;
using System.Threading;
class CirclePerimeterAndArea
{
    // Write a program that reads the radius r of a circle and prints its perimeter and area 
    // formatted with 2 digits after the decimal point.
    // Examples:r=2,	perimeter=12,57,	area=12,57.
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter radius (r): ");
        double r = double.Parse(Console.ReadLine());
        double circlePerimeter = 2 * Math.PI * r;
        double circleArea = Math.PI * r * r;
        Console.WriteLine("Circle with radius: {0} \nPerimeter: {1:F2} \nArea: {2:F2}", r, circlePerimeter, circleArea);
    }
}
