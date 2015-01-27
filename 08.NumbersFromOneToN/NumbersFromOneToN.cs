using System;
class NumbersFromOneToN
{
    // Write a program that reads an integer number n from the console and prints all the numbers in 
    // the interval [1..n], each on a single line.     Note: You may need to use a for-loop.
    // Examples : input=3 ,	output= 1,2,3.
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
