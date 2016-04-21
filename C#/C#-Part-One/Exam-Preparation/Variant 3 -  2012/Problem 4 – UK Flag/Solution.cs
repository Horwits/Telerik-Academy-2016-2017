using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstAndSecondPartHeight = n / 2,
            innerDots = n / 2 - 1,
            outterDots = 0;

        for (int i = 0; i < firstAndSecondPartHeight; i++)
        {
            Console.Write(new string('.', outterDots));
            Console.Write(new string('\\', 1));
            Console.Write(new string('.', innerDots));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', innerDots));
            Console.Write(new string('/', 1));
            Console.WriteLine(new string('.', outterDots));

            outterDots++;
            innerDots--;
        }

        int outterDash = n / 2;
        Console.Write(new string('-', outterDash));
        Console.Write(new string('*', 1));
        Console.WriteLine(new string('-', outterDash));

        for (int i = 0; i < firstAndSecondPartHeight; i++)
        {
            outterDots--;
            innerDots++;

            Console.Write(new string('.', outterDots));
            Console.Write(new string('/', 1));
            Console.Write(new string('.', innerDots));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', innerDots));
            Console.Write(new string('\\', 1));
            Console.WriteLine(new string('.', outterDots));
        }

    }
}
