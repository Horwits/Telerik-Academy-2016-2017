using System;

class Solution
{
    static void Main()
    {
        var x = int.Parse(Console.ReadLine());

        int y = x - 1,
            z = (x / 2),
            width = (2 * (x / 2 + y)) + 1,
            upperPartHeight = x - 2;

        int firstDots = z,
            secondDots = 1,
            upperPartInnerDots = width - (2 + 2 * firstDots);

        //upperPart
        Console.Write(new string('.', firstDots));
        Console.Write(new string('*', 1));
        Console.Write(new string('.', upperPartInnerDots));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('.', firstDots));

        firstDots--;
        upperPartInnerDots -= 2;
        for (int i = 0; i < upperPartHeight; i++)
        {
            if (i < z)
            {
                Console.Write(new string('.', firstDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', secondDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', upperPartInnerDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', secondDots));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', firstDots));

                if (firstDots >= 0)
                {
                    firstDots--;
                }
            }
            else
            {
                secondDots = (width - (2 + upperPartInnerDots)) / 2;
                Console.Write(new string('.', secondDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', upperPartInnerDots));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', secondDots));
            }

            upperPartInnerDots -= 2;
            secondDots += 2;
        }

        //downPart
        int downPartHeight = 2 * x - 3,
            downPartOutterDots = x / 2 + y;

        Console.Write(new string('.', downPartOutterDots));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('.', downPartOutterDots));

        int innerDots = -1;
        for (int i = 0; i < downPartHeight; i++)
        {
            if (i <= x - 2)
            {
                downPartOutterDots--;
                innerDots += 2;
            }
            else
            {
                downPartOutterDots++;
                innerDots -= 2;
            }

            Console.Write(new string('.', downPartOutterDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', innerDots));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', downPartOutterDots));
        }

        downPartOutterDots++;
        Console.Write(new string('.', downPartOutterDots));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('.', downPartOutterDots));
    }
}
