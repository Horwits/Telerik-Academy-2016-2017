using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int halfLength = n / 2;

        int outterDots = 0;
        int innerDots = 2;
        for (int row = 0; row < halfLength; row++)
        {
            outterDots = (halfLength - 1) - row;
            Console.Write(new string('.', outterDots));
            Console.Write(new string('#', 1));

            if (row > 0)
            {
                Console.Write(new string('.', innerDots));
                innerDots += 2;
            }

            Console.Write(new string('#', 1));
            Console.Write(new string('.', outterDots));

            Console.WriteLine();
        }
        innerDots -= 2;

        Console.Write(new string('.', outterDots));
        Console.Write(new string('#', 1));
        Console.Write(new string('.', innerDots));
        Console.Write(new string('#', 1));
        Console.Write(new string('.', outterDots));

        Console.WriteLine();

        int downPartLength = (halfLength / 2) - 1;
        for (int i = 0; i < downPartLength; i++)
        {
            outterDots++;
            innerDots -= 2;

            Console.Write(new string('.', outterDots));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', innerDots));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', outterDots));

            Console.WriteLine();
        }

        Console.WriteLine(new string('-', n));

        outterDots = 0;
        for (int row = 0; row < halfLength; row++)
        {
            Console.Write(new string('.', outterDots + row));
            Console.Write(new string('\\', halfLength - row));
            Console.Write(new string('/', halfLength - row));
            Console.Write(new string('.', outterDots + row));

            Console.WriteLine();
        }
    }
}
