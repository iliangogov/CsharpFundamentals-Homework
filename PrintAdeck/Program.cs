using System;

namespace PrintAdeck
{
    class Program
    {
        static void Main()
        {
            int card = Console.Read();
            if (card == 49) { card = 58; } //desetka
            if (card == 74) { card = 59; } //vale
            if (card == 81) { card = 60; } //dama
            if (card == 75) { card = 61; } //pop
            if (card == 65) { card = 62; } //aso
            int i;
            for (i = 50; i <= card; i++)
            {
                switch (i)
                {
                    case 50: Console.WriteLine("2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds"); break;
                    case 51: Console.WriteLine("3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds"); break;
                    case 52: Console.WriteLine("4 of spades, 4 of clubs, 4 of hearts, 4 of diamonds"); break;
                    case 53: Console.WriteLine("5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds"); break;
                    case 54: Console.WriteLine("6 of spades, 6 of clubs, 6 of hearts, 6 of diamonds"); break;
                    case 55: Console.WriteLine("7 of spades, 7 of clubs, 7 of hearts, 7 of diamonds"); break;
                    case 56: Console.WriteLine("8 of spades, 8 of clubs, 8 of hearts, 8 of diamonds"); break;
                    case 57: Console.WriteLine("9 of spades, 9 of clubs, 9 of hearts, 9 of diamonds"); break;
                    case 58: Console.WriteLine("10 of spades, 10 of clubs, 10 of hearts, 10 of diamonds"); break;
                    case 59: Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds"); break;
                    case 60: Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds"); break;
                    case 61: Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds"); break;
                    case 62: Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds"); break;
                    default: Console.WriteLine("Invalid Card"); break;
                }
            }
        }
    }
}
