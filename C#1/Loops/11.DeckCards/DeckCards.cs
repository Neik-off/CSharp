using System;

class Program
{
    static void Main()
    {
        string card="";
        string suit = "";
        Console.WriteLine("Standart Deck:");
        for (int i = 1; i <= 4; i++)
        {
            switch (i)
            {
                case 1: suit = "Spades"; break;
                case 2: suit = "Hearts"; break;
                case 3: suit = "Diamonds"; break;
                case 4: suit = "Clubs"; break;
                default: break;
            }
            for (int k = 1; k <= 13; k++)
            {
                switch (k)
                {
                    case 1: card = "Ace";
                        break;
                    case 2: card = "2";
                        break;
                    case 3: card = "3";
                        break;
                    case 4: card = "4";
                        break;
                    case 5: card = "5";
                        break;
                    case 6: card = "6";
                        break;
                    case 7: card = "7";
                        break;
                    case 8: card = "8";
                        break;
                    case 9: card = "9";
                        break;
                    case 10: card = "10";
                        break;
                    case 11: card = "Jack";
                        break;
                    case 12: card = "Queen";
                        break;
                    case 13: card = "King";
                        break;
                    default:
                        break;
                }
                Console.Write("|"+suit+" "+card+"|");
                if(k%5==0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("================================================================");
        }
    }
}
