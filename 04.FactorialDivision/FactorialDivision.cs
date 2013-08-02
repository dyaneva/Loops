// Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class FactorialDivision
{
    static void Main()
    {
        Console.Write("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number k = ");
        int k = int.Parse(Console.ReadLine());
        decimal factorialN = 1; // for large values, should be used BigInteger
        decimal factorialK = 1; // for large values, should be used BigInteger
        decimal result; // for large values, should be used BigInteger
        if (1<k && k<n)
        {
            while (n > 0)
            {
                factorialN *= n;
                n--;
            } 
            
            while(k > 0)
            {
                factorialK *= k;
                k--;
            }
            result = factorialN / factorialK;
            Console.WriteLine("N!/K! = {0}", result);
        }
        else
	    {
            Console.WriteLine("Ïncorrect condition!");
	    }


        /* Variant 2
        
        Console.Write("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number k = ");
        int k = int.Parse(Console.ReadLine());
        decimal result=1; // for large values, should be used BigInteger
        if (1<k && k<n)
        {
            for (int i = n; i > k; i--)
            {
                result *= i;
            }                
            Console.WriteLine("N!/K! = {0}", result);
        }
        else
        {
            Console.WriteLine("Ïncorrect condition!");
        }*/
    }
}    

