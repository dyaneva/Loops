// Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
// Use the Euclidean algorithm. 

using System;

class GCD
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int remainder = 1;
        if (firstNumber == 0 ^ secondNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        else
        {
            while (remainder != 0)
            {
                remainder = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = remainder;
            }
            Console.WriteLine("The Greatest Common Divisor is {0}", firstNumber);
        }
    }
}

