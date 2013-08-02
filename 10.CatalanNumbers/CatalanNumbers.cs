// Write a program to calculate the Nth Catalan number by given N.
// Cn = (2n)!/(n+1)!*n! for n>=0

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger resultDivision = 1; 
        BigInteger factorialN = 1; 
        BigInteger result; 
        if (n >= 0)
        {
            for (int i = 2 * n; i > (n + 1); i--)
            {
                resultDivision *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            result = resultDivision / factorialN;
            Console.WriteLine("Cn = {0}", result);
        }
        else
        {
            Console.WriteLine("Incorrect condition!");
        }        
    }
}    

