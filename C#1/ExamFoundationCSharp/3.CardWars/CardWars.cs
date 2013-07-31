using System;

class CardWars
{
    static void Main()
    {
        int N =int.Parse(Console.ReadLine());

        
        bool playerOneX = false;        
        bool playerTwoX = false;
        int playerOneGamesWon = 0;
        int playerTwoGamesWon = 0;
        int playerOneScore = 0;
        int playerTwoScore = 0;


        for (int i = 0; i < N; i++)
		{
            int playerOneHandStr = 0;
            int playerTwoHandStr = 0;
            for (int j = 0; j < 3; j++)
            {
                string card=Console.ReadLine();
                if(card=="Z")
                {
                    playerOneScore *= 2;
                }
                else if(card=="Y")
                {
                    playerOneScore -= 200;
                }
                else if(card=="X")
                {
                    playerOneX = true;
                }
                else
                {
                    switch (card)
                    {
                        case "K": playerOneHandStr += 13; break;
                        case "Q": playerOneHandStr += 12; break;
                        case "J": playerOneHandStr += 11; break;
                        case "10": playerOneHandStr += 2; break;
                        case "9": playerOneHandStr += 3; break;
                        case "8": playerOneHandStr += 4; break;
                        case "7": playerOneHandStr += 5; break;
                        case "6": playerOneHandStr += 6; break;
                        case "5": playerOneHandStr += 7; break;
                        case "4": playerOneHandStr += 8; break;
                        case "3": playerOneHandStr += 9; break;
                        case "2": playerOneHandStr += 10; break;
                        case "A": playerOneHandStr += 1; break;
                        default: break;   
                    }
                }
                
            }
            for (int k = 0; k < 3; k++)
            {
                string card = Console.ReadLine();
                if (card == "Z")
                {
                    playerTwoScore *= 2;
                }
                else if (card == "Y")
                {
                    playerTwoScore -= 200;
                }
                else if (card == "X")
                {
                    playerTwoX = true;
                }
                else
                {
                    switch (card)
                    {
                        case "K": playerTwoHandStr += 13; break;
                        case "Q": playerTwoHandStr += 12; break;
                        case "J": playerTwoHandStr += 11; break;
                        case "10": playerTwoHandStr += 2; break;
                        case "9": playerTwoHandStr += 3; break;
                        case "8": playerTwoHandStr += 4; break;
                        case "7": playerTwoHandStr += 5; break;
                        case "6": playerTwoHandStr += 6; break;
                        case "5": playerTwoHandStr += 7; break;
                        case "4": playerTwoHandStr += 8; break;
                        case "3": playerTwoHandStr += 9; break;
                        case "2": playerTwoHandStr += 10; break;
                        case "A": playerTwoHandStr += 1; break;
                        default: break;
                    }
                }
            }
            //Winner Checking
            if(playerOneX && !playerTwoX)
            {
                playerOneGamesWon++;
                Console.WriteLine("X card drawn! Player one wins the match!");
                playerOneX = false;
                break;
            }
            else if (playerTwoX &&!playerOneX)
            {
                playerTwoGamesWon++;
                Console.WriteLine("X card drawn! Player two wins the match!");
                playerTwoX = false;
                break;
            }
            else if (playerOneX && playerTwoX)
            {
                playerOneScore += 50;
                playerTwoScore += 50;
                playerTwoX = false;
                playerOneX = false;
            }
            else
            {
                if(playerOneHandStr>playerTwoHandStr)
                {
                    playerOneGamesWon++;
                    playerOneScore += playerOneHandStr;
                }
                else if(playerTwoHandStr>playerOneHandStr)
                {
                    playerTwoGamesWon++;
                    playerTwoScore += playerTwoHandStr;
                }
            }
            if(i==N-1)
            {
                if(playerOneScore>playerTwoScore)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: {0}",playerOneScore);
                    Console.WriteLine("Games won: {0}",playerOneGamesWon);
                }
                else if (playerTwoScore > playerOneScore)
                {
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: {0}", playerTwoScore);
                    Console.WriteLine("Games won: {0}", playerTwoGamesWon);
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Score: {0}", playerOneScore);
                }                
            }
            
		}
    }
}
