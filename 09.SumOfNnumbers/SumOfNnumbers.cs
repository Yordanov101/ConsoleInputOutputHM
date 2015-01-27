using System;
class SumOfNnumbers
{
    // Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
    // Note: You may need to use a for-loop.
    // Examples: numbers=20,60,10;	sum=90.
    static void Main()
    {
        Console.WriteLine("Please enter a numbers separated by space  :");
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
