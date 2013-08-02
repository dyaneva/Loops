// Write a program that, for a given two integer numbers N and X, 
// calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

using System;

class SumOfSequence
{
    static void Main()
    {
        Console.Write("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number x = ");
        int x = int.Parse(Console.ReadLine());
        decimal sum = 1;
        decimal resultX = 1;
        decimal factorialN = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            resultX *= x;
            sum += (factorialN/resultX);                 
        }
        Console.WriteLine("The sum of sequence S=1+1!/X+2!/X2+…+N!/X^N is: {0}", sum);
    }
}    

