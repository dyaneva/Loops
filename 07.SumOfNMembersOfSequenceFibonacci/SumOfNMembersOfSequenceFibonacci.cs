// Write a program that reads a number N and calculates the sum of the first N members 
// of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class SumOfNMembersOfSequenceFibonacci
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger number1 = 0;
        BigInteger number2 = 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(number1);
            BigInteger sum = number1 + number2;
            number1 = number2;
            number2 = sum;
        }      
    }
}    

