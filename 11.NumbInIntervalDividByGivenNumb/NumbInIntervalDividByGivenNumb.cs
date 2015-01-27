using System;
class NumbInIntervalDividByGivenNumb
{
    // Write a program that reads two positive integer numbers and prints how many numbers p exist 
    // between them such that the reminder of the division by 5 is 0.
    //Examples : start=17,	end=25, 	p=2,	comments=20,25
    static void Main()
    {
        Console.WriteLine("Enter start number: ");
        int nStart = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end number :");
        int nEnd = int.Parse(Console.ReadLine());

        
            int p = 0;
            for (int i = nStart; i <= nEnd; i++)
            {
                if ((i % 5) == 0)
                {
                    p++;
                    Console.Write(i + " and ");
                }
            }
            Console.WriteLine("\nnumbers of (p) :" + p);
    }
}
