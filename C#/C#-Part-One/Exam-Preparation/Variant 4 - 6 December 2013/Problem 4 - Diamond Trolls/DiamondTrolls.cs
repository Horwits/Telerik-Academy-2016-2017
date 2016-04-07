using System;

class DiamondTrolls
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n * 2 + 1,
            height = (6 + ((n - 3) / 2) * 3),
            firstPartHeight = (height - n) - 1,
            secondPartHeight = (height - firstPartHeight) - 1,
            outerDots = (width - n) / 2,
            innerDots = 0;

        for (int i = 0; i < firstPartHeight; i++)
        {
            if (i == 1)
            {
                innerDots = outerDots;
            }

            Console.Write(new string('.', outerDots));
            if (i < 1)
            {
                Console.Write(new string('*', n));
            }
            else
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('.', innerDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', innerDots));
                Console.Write(new string('*', 1));

            }
            Console.Write(new string('.', outerDots));
            Console.WriteLine();

            outerDots--;
            innerDots++;
        }

        Console.WriteLine(new string('*', width));

        outerDots++;
        innerDots--;

        for (int i = 0; i < secondPartHeight; i++)
        {
            if (i == secondPartHeight - 1)
            {
                Console.Write(new string('.', outerDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', outerDots));
            }
            else
            {
                Console.Write(new string('.', outerDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', innerDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', innerDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', outerDots));
            }
            Console.WriteLine();

            if (innerDots > 0)
            {
                innerDots--;
            }

            outerDots++;
        }
    }
}
