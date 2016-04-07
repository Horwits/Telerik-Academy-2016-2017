using System;

class DeckOfCards
{
    static void Main()
    {
        /*Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).

        The card faces should start from 2 to A.
        Print each card face in its four possible suits: clubs, diamonds, hearts and spades.*/

        string input = Console.ReadLine();

        int lastCard = 0;
        #region Input
        switch (input)
        {
            case "2":
                lastCard = int.Parse(input);
                break;
            case "3":
                lastCard = int.Parse(input);
                break;
            case "4":
                lastCard = int.Parse(input);
                break;
            case "5":
                lastCard = int.Parse(input);
                break;
            case "6":
                lastCard = int.Parse(input);
                break;
            case "7":
                lastCard = int.Parse(input);
                break;
            case "8":
                lastCard = int.Parse(input);
                break;
            case "9":
                lastCard = int.Parse(input);
                break;
            case "10":
                lastCard = int.Parse(input);
                break;
            case "J":
                lastCard = 11;
                break;
            case "Q":
                lastCard = 12;
                break;
            case "K":
                lastCard = 13;
                break;
            case "A":
                lastCard = 14;
                break;
        }
        #endregion

        for (int i = 2; i <= lastCard; i++)
        {
            string[] colors = { "spades", "clubs", "hearts", "diamonds" };
            for (int j = 0; j < colors.Length; j++)
            {
                #region Printing
                switch (i)
                {
                    case 2:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 3:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 4:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 5:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 6:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 7:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 8:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 9:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 10:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", i, colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", i, colors[j]);
                        }
                        break;

                    case 11:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", "J", colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", "J", colors[j]);
                        }
                        break;

                    case 12:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", "Q", colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", "Q", colors[j]);
                        }
                        break;

                    case 13:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", "K", colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", "K", colors[j]);
                        }
                        break;

                    case 14:
                        if (j != colors.Length - 1)
                        {
                            Console.Write("{0} of {1}, ", "A", colors[j]);
                        }
                        else
                        {
                            Console.WriteLine("{0} of {1}", "A", colors[j]);
                        }
                        break;
                }
                #endregion
            }
        }
    }
}
