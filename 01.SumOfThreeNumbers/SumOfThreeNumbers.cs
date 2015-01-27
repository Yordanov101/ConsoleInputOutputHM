using System;
class SumOfThreeNumbers
{
    // Write a program that reads 3 real numbers from the console and prints their sum.
    // Examples: a=3,	b=4,	c=11,	sum=18.
    static void Main()
    {
        Console.Write("Please enter a number (a):");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number (b):");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter a number (c):");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine(a+" + "+b+" + "+c+"=" +(a+b+c));
    }
}
