﻿/* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 
 * Examples: N = 10  N! = 3628800  2 
 *           N = 20  N! = 2432902008176640000  4 
 * Does your program work for N = 50 000? 
 * Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5.*/ 

using System;

class TrailingZerosAtEndOfFactorial
{
    static void Main()
    {
        Console.Write("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());
        int counterZeroes = 0;
        int divisor = 5;
        int result = 0;
        do
        {                
            result = n / divisor;
            divisor *= 5;
            counterZeroes += result;
        }
        while (result != 0);
        Console.WriteLine("The trailing zeros at the end of the number {0}! are {1}", n, counterZeroes);
    }
}
    

    

