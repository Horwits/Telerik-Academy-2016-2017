using System;
using System.Text;

class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int drawingAreaWidth = 3 * (n + 1);

        int outterDots = n + 1;

        int firstpart = n - 1;
        for (int i = 0; i < firstpart; i++)
        {
            if (i < 1)
            {
                Console.Write(new string('.', outterDots));
                Console.Write(new string('*', (drawingAreaWidth - (2 * outterDots))));
                Console.Write(new string('.', outterDots));
            }
            else
            {
                Console.Write(new string('.', outterDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', drawingAreaWidth - (2 * outterDots + 2)));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', outterDots));
            }

            if (outterDots > 1)
            {
                outterDots -= 2;
            }

            Console.WriteLine();
        }

        #region crack part

        int eggWidth = 3 * n - 1;
        //first crack row
        Console.Write(new string('.', outterDots));
        Console.Write(new string('*', outterDots));
        var firstRowCrack = new StringBuilder();
        for (int i = 0; i < eggWidth; i++)
        {
            if (i % 2 == 0)
            {
                firstRowCrack.Append('@');
            }
            else
            {
                firstRowCrack.Append('.');
            }
        }
        Console.Write(firstRowCrack.ToString());
        Console.Write(new string('*', outterDots));
        Console.Write(new string('.', outterDots));
        Console.WriteLine();

        //second crack row
        Console.Write(new string('.', outterDots));
        Console.Write(new string('*', outterDots));
        var secondRowCrack = new StringBuilder();
        for (int i = 0; i < eggWidth; i++)
        {
            if (i % 2 == 0)
            {
                secondRowCrack.Append('.');
            }
            else
            {
                secondRowCrack.Append('@');
            }
        }
        Console.Write(secondRowCrack.ToString());
        Console.Write(new string('*', outterDots));
        Console.Write(new string('.', outterDots));
        Console.WriteLine();

        #endregion

        int secondPart = n - 1;
        for (int i = 0; i < secondPart; i++)
        {
            if (i == secondPart - 1)
            {
                Console.Write(new string('.', outterDots));
                Console.Write(new string('*', (drawingAreaWidth - (2 * outterDots))));
                Console.Write(new string('.', outterDots));
            }
            else
            {
                Console.Write(new string('.', outterDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', drawingAreaWidth - (2 * outterDots + 2)));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', outterDots));
            }

            if (i >= (n / 2) - 2)
            {
                outterDots += 2;
            }

            Console.WriteLine();
        }
    }
}
