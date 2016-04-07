using System;

class Cube3D
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int canvasWidth = n + (n - 1),
            verticalLineLength = 0,
            outterEmptySymbolLength = canvasWidth - n,
            firstPart = n - 2,
            innerEmptySymbolsLength = firstPart;

        //first row 
        Console.Write(new string(':', n));
        Console.WriteLine(new string(' ', outterEmptySymbolLength));

        for (int i = 0; i < firstPart; i++)
        {
            Console.Write(new string(':', 1));
            Console.Write(new string(' ', innerEmptySymbolsLength));
            Console.Write(new string(':', 1));
            Console.Write(new string('|', verticalLineLength));
            Console.WriteLine(new string(':', 1));

            verticalLineLength++;
        }

        //middle row
        Console.Write(new string(':', n));
        Console.Write(new string('|', verticalLineLength));
        Console.WriteLine(new string(':', 1));

        int secondPart = firstPart,
            innerMinusSymbolLength = n - 2;
        outterEmptySymbolLength = 1;

        for (int i = 0; i < secondPart; i++)
        {
            verticalLineLength--;

            Console.Write(new string(' ', outterEmptySymbolLength));
            Console.Write(new string(':', 1));
            Console.Write(new string('-', innerMinusSymbolLength));
            Console.Write(new string(':', 1));
            Console.Write(new string('|', verticalLineLength));
            Console.WriteLine(new string(':', 1));

            outterEmptySymbolLength++;
        }
        //last row
        Console.Write(new string(' ', outterEmptySymbolLength));
        Console.WriteLine(new string(':', n));
    }
}
