using System;
class FibonacciNumbers
{
    // Write a program that reads a number (n) and prints on the console the first (n) members of the Fibonacci 
    // sequence (at a single line,separated by comma and space -,): 0,1,1,2,3,5,8,13,21,34,55,89,144,233, ….
    // Examples : n	=3.      comments=0 1 1.
    static void Main()
    {
        Console.WriteLine("Enter number (n): ");
        int n = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        int temp = 0;
        Console.Write(firstNumber + ", " + secondNumber + ", ");

        for (int i = 2; i < n; i++)
        {
            temp = firstNumber + secondNumber;
            Console.Write(temp + ", ");
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        Console.WriteLine();
    }
}
