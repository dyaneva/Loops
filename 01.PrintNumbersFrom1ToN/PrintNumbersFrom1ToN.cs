//Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);            
        }
        Console.WriteLine();
    }
}
    

