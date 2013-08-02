// Write a program that reads from the console a sequence of N integer numbers and returns 
// the minimal and maximal of them.

using System;
using System.Linq;

class MinAndMaxOfNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers the sequence contains: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int minNumber = numbers.Min();
        int maxNumber = numbers.Max();
        Console.WriteLine("The minimal number of this sequence is {0}\nThe maximal number of this sequence is {1}", minNumber, maxNumber);

        /* Variant 2
        
        Console.Write("Enter how many numbers the sequence contains: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int minNumber = numbers[0];
        int maxNumber = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {            
            if (numbers[i]<minNumber)
            {
                minNumber = numbers[i];
            }
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        Console.WriteLine("The minimal number of this sequence is {0}\nThe maximal number of this sequence is {1}", minNumber, maxNumber);
        */
    }
}    

