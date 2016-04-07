using System;
using System.Numerics;

class CardWars
{
    static long AddCardPointsToResult(string card)
    {
        long result = 0;
        switch (card)
        {
            case "2": result += 10; break;
            case "3": result += 9; break;
            case "4": result += 8; break;
            case "5": result += 7; break;
            case "6": result += 6; break;
            case "7": result += 5; break;
            case "8": result += 4; break;
            case "9": result += 3; break;
            case "10": result += 2; break;
            case "A": result += 1; break;
            case "J": result += 11; break;
            case "Q": result += 12; break;
            case "K": result += 13; break;
        }

        return result;
    }

    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());

        BigInteger playerOneScore = 0,
            playerTwoScore = 0;

        int playerOneGamesWon = 0,
            playerTwoGamesWon = 0;

        bool playerOneXCardWin = false,
            playerTwoXCardWin = false;

        for (int round = 0; round < rounds; round++)
        {
            int playerOneXDrawn = 0,
                playerOneYDrawn = 0,
                 playerOneZDrawn = 0;

            int playerTwoXDrawn = 0,
                playerTwoYDrawn = 0,
                 playerTwoZDrawn = 0;

            #region playerOne hand
            BigInteger playerOneHandStrength = 0;
            for (int card = 0; card < 3; card++)
            {
                string playerOneCard = Console.ReadLine();
                bool isSpecialCard = playerOneCard == "Z" || playerOneCard == "Y" || playerOneCard == "X";

                if (!isSpecialCard)
                {
                    playerOneHandStrength += AddCardPointsToResult(playerOneCard);
                }
                else
                {
                    switch (playerOneCard)
                    {
                        case "X":
                            playerOneXDrawn++;
                            break;
                        case "Y":
                            playerOneYDrawn++;
                            break;
                        case "Z":
                            playerOneZDrawn++;
                            break;
                    }
                }
            }
            #endregion

            #region playerTwo hand
            BigInteger playerTwoHandStrength = 0;
            for (int card = 0; card < 3; card++)
            {
                string playerTwoCard = Console.ReadLine();
                bool isSpecialCard = playerTwoCard == "Z" || playerTwoCard == "Y" || playerTwoCard == "X";

                if (!isSpecialCard)
                {
                    playerTwoHandStrength += AddCardPointsToResult(playerTwoCard);
                }
                else
                {
                    switch (playerTwoCard)
                    {
                        case "X":
                            playerTwoXDrawn++;
                            if (playerOneXDrawn == 0)
                            {
                                playerTwoXCardWin = true;
                                break;
                            }
                            break;
                        case "Y":
                            playerTwoYDrawn++;
                            break;
                        case "Z":
                            playerTwoZDrawn++;
                            break;
                    }
                }
            }
            #endregion

            if (playerTwoXCardWin == true)
            {
                break;
            }
            else
            {
                if ((playerOneXDrawn > playerTwoXDrawn) && playerTwoXDrawn == 0)
                {
                    playerOneXCardWin = true;
                    break;
                }
                else if (playerOneXDrawn != 0 && playerTwoXDrawn != 0)
                {
                    playerOneHandStrength += 50;
                    playerTwoHandStrength += 50;
                }

                //Z
                if (playerOneZDrawn > 0)
                {
                    playerOneHandStrength *= (long)Math.Pow(2, playerOneZDrawn);
                }

                if (playerTwoZDrawn > 0)
                {
                    playerTwoHandStrength *= (long)Math.Pow(2, playerTwoZDrawn);
                }

                //Y
                if (playerOneYDrawn > 0)
                {
                    playerOneHandStrength += (playerOneYDrawn * 200) * (-1);
                }

                if (playerTwoYDrawn > 0)
                {
                    playerTwoHandStrength += (playerTwoYDrawn * 200) * (-1);
                }

                if (playerOneHandStrength > playerTwoHandStrength)
                {
                    playerOneScore += playerOneHandStrength;
                    playerOneGamesWon++;
                }
                else if (playerOneHandStrength < playerTwoHandStrength)
                {
                    playerTwoScore += playerTwoHandStrength;
                    playerTwoGamesWon++;
                }
            }
        }

        if (playerOneXCardWin)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (playerTwoXCardWin)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (playerOneScore > playerTwoScore && (playerOneXCardWin == false || playerTwoXCardWin == false))
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", playerOneScore);
            Console.WriteLine("Games won: {0}", playerOneGamesWon);
        }
        else if (playerTwoScore > playerOneScore && (playerOneXCardWin == false || playerTwoXCardWin == false))
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", playerTwoScore);
            Console.WriteLine("Games won: {0}", playerTwoGamesWon);
        }
        else if (playerOneScore == playerTwoScore && (playerOneXCardWin == false || playerTwoXCardWin == false))
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", playerOneScore);
        }
    }
}
