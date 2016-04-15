using System;

class EasterMisterSolution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 3 * n + 1;

        int outterDots = n + 1;
        //top
        Console.Write(new string('.', outterDots));
        Console.Write(new string('*', n - 1));
        Console.WriteLine(new string('.', outterDots));

        outterDots -= 2;
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', outterDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', width - (2 * outterDots + 2)));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', outterDots));
            outterDots -= 2;
        }

        //middle Drowing
        int length = width - 4;
        for (int i = 0; i < 2; i++)
        {
            Console.Write(new string('.', 1));
            Console.Write(new string('*', 1));

            for (int j = 0; j < length; j++)
            {
                if (i == 0)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write('.');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
            }

            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', 1));
        }


        outterDots += 2;
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('.', outterDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', width - (2 * outterDots + 2)));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', outterDots));
            outterDots += 2;
        }
        //bottom
        Console.Write(new string('.', outterDots));
        Console.Write(new string('*', n - 1));
        Console.WriteLine(new string('.', outterDots));
    }
}
