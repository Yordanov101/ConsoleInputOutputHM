using System;
class SumOfFiveNumbers
{
    // Write a program that enters 5 numbers (given in a single line, separated by a space),
    // calculates and prints their sum.
    //  Examples : numbers= 1 2 3 4 5,	sum=15.
    static void Main()
    {
        Console.WriteLine("Enter five numbers separated with space: ");
        string sequence = Console.ReadLine();
        string[] numbers = sequence.Split(new Char[] { ' ' });
        double sum = 0;
        foreach (string n in numbers)
        {
            sum += double.Parse(n);
        }

        Console.WriteLine("Sum = {0}", sum);
    }
}
