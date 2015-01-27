using System;
using System.Globalization;
using System.Threading;

namespace _04.NumberComparer
{
    // Write a program that gets two numbers from the console and prints the greater of them.
    // Try to implement this without if statements.
    // Examples: a=5,	b=6,	greater=6.
    class NumberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = 
                CultureInfo.InvariantCulture;
            Console.Write("Enter number (a): ");

            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number (b): ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is: " + Math.Max(a,b));
        }
    }
}
