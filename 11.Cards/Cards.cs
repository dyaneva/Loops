// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
// The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class Cards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        string[] color = { "Diamonds", "Hearts", "Spades", "Clubs"};
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(cards[i] + " " + color[j]);                
            }
            Console.WriteLine();
        }

        /* Variant2 with switch-case
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {                    
                switch (j)
                {
                    case 0:
                        Console.WriteLine(cards[i] + " Hearts");
                        break;
                    case 1:
                        Console.WriteLine(cards[i] + " Diamonds");
                        break;
                    case 2:
                        Console.WriteLine(cards[i] + " Spades");
                        break;
                    case 3:
                        Console.WriteLine(cards[i] + " Clubs");
                        break;
                    default:
                        Console.WriteLine("Mistake!");
                        break;
                }
            }  
        } 
        */
    }
}
     
        

   

