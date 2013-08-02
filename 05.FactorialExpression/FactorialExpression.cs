// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class FactorialExpression
{
    static void Main()
    {        
        Console.Write("Enter a number k = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1; 
        BigInteger factorialDivision = 1; 
        BigInteger result; 
        if (1 < n && n < k)
        {
            for (int i = k; i > (k - n); i--)
            {
                factorialDivision *= i;
            }
            while (n > 0)
            {
                factorialN *= n;
                n--;
            }
            result = factorialN * factorialDivision;
            Console.WriteLine("N!*K!/(K-N)! = {0}", result);
        }
        else
        {
            Console.WriteLine("Ïncorrect condition!");
        }
    }
}    

