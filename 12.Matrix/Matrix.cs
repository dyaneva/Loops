// Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix. 

using System;

class Matrix
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number N= ");
        while (int.TryParse(Console.ReadLine(), out n) && (n < 0) ^ (n >=20))
        {
            Console.WriteLine("Enter a number( 0<N<20 ): ");
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 1 + i; j <= n + i; j++)
            {
                Console.Write("{0:00 }", j);
            }
            Console.WriteLine();
        }
    }
}
        
        
       
       

    

    
