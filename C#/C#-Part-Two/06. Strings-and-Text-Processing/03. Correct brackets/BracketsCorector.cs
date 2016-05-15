﻿using System;

class BracketsCorector
{
    static void PrintOnConsoleIfBracketsAreCorrect(string expression)
    {
        int openBracketIndex = 0;
        int closeBracketIndex = 0;

        int openBracketCounter = 0;
        int closeBracketCounter = 0;

        int openBracketFound = 0;
        int closeBracketFound = 0;

        bool areBracketsCorrect = true;
        while (openBracketFound != -1 || closeBracketFound != -1)
        {
            if (openBracketFound + 1 == closeBracketFound)
            {
                areBracketsCorrect = false;
                break;
            }

            if (openBracketFound > closeBracketFound || openBracketCounter != closeBracketCounter)
            {
                areBracketsCorrect = false;
                break;
            }

            openBracketFound = expression.IndexOf('(', openBracketIndex);
            closeBracketFound = expression.IndexOf(')', closeBracketIndex);


            if (openBracketFound != -1)
            {
                openBracketCounter++;
            }

            if (closeBracketFound != -1)
            {
                closeBracketCounter++;
            }

            openBracketIndex = openBracketFound + 1;
            closeBracketIndex = closeBracketFound + 1;
        }

        if (areBracketsCorrect)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }

    static void Main()
    {
        var expression = Console.ReadLine();

        PrintOnConsoleIfBracketsAreCorrect(expression);
    }
}
