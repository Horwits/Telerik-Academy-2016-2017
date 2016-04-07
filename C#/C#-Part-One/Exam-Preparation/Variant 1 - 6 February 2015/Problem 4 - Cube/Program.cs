using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int canvasWidth = n + (n - 1),
            firstPartHeight = n - 1;

        int xSymbolsLength = 0,
            emptySymbolsLength = canvasWidth - n,
            slashLength = n - 2;

        for (int i = 0; i < firstPartHeight; i++)
        {
            Console.Write(new string(' ', emptySymbolsLength));
            if (i == 0)
            {
                Console.Write(new string(':', n - 1));
            }
            else
            {
                Console.Write(new string(':', 1));
            }

            if (i >= 1)
            {
                Console.Write(new string('/', slashLength));
                Console.Write(new string(':', 1));
                Console.Write(new string('X', xSymbolsLength));
                xSymbolsLength++;
            }

            Console.WriteLine(new string(':', 1));

            emptySymbolsLength--;
        }

        //middle row
        Console.Write(new string(':', n));
        Console.Write(new string('X', xSymbolsLength));
        Console.WriteLine(new string(':', 1));

        int secondPartHeight = firstPartHeight - 1,
            inCubeEmptySymbolsLength = xSymbolsLength;

        for (int i = 0; i < secondPartHeight; i++)
        {
            xSymbolsLength--;

            Console.Write(new string(':', 1));
            Console.Write(new string(' ', inCubeEmptySymbolsLength));
            Console.Write(new string(':', 1));
            Console.Write(new string('X', xSymbolsLength));
            Console.WriteLine(new string(':', 1));

            emptySymbolsLength++;
        }

        //last row
        Console.Write(new string(':', n));
        Console.WriteLine(new string(' ', canvasWidth - n));
    }
}
