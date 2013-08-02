// Write a program that reads a positive integer number N (N < 20) from console and outputs in the console 
// the numbers 1 ... N numbers arranged as a spiral.

using System;

class NumbersInSpiral
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number N= ");
        while (int.TryParse(Console.ReadLine(), out n) && (n < 0) ^ (n >= 20))
        {
            Console.Write("Enter a number( 0<N<20 ): ");
        }
        int[,] matrix = new int[n, n];
        int number = 1;
        for (int i = 0; i < n*n; i++)
        {
            for (int col = i; col < n - i; col++)
            {
                matrix[i, col] = number;
                number++;
            }

            for (int row = 1 + i; row < n - i; row++)
            {
                matrix[row, n - 1 - i] = number;
                number++;
            }

            for (int col = n - 2 - i; col >= i; col--)
            {
                matrix[n - 1 - i, col] = number;
                number++;
            }

            for (int row = n - 2 - i; row > i; row--)
            {
                matrix[row, i] = number;
                number++;
            }
        }
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
 
        
    
     
    

