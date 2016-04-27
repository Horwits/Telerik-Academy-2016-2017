using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char c = Console.ReadLine()[0];

        int headHeight = (n / 2) / 2,
            headWidth = headHeight + 1,
            neckWidth = headHeight - 1;
        //body

        Console.Write(new string(' ', 1));
        Console.Write(new string(c, 1));
        Console.Write(new string(' ', neckWidth));
        Console.WriteLine(new string(c, 1));

        for (int i = 0; i < headHeight - 1; i++)
        {
            Console.Write(new string(' ', 1));
            Console.Write(new string(c, headWidth));
            Console.WriteLine();
        }

        for (int i = 0; i < headHeight - 1; i++)
        {
            Console.Write(new string(' ', 2));
            Console.Write(new string(c, neckWidth));
            Console.WriteLine();
        }

        for (int i = 0; i < headHeight - 1; i++)
        {
            Console.Write(new string(' ', 1));
            Console.Write(new string(c, headWidth));
            Console.WriteLine();
        }

        Console.Write(new string(' ', 1));
        Console.Write(new string(c, headWidth));
        Console.Write(new string(' ', 3));
        Console.WriteLine(new string(c, headWidth - 1));

        int bodyHeight = n - (3 * (headHeight - 1) + 2),
            bodyWidth = headWidth + 2;

        for (int i = 0; i < bodyHeight - 2; i++)
        {
            Console.Write(new string(c, bodyWidth));
            Console.Write(new string(' ', 2));
            Console.WriteLine(new string(c, 1));
        }

        Console.Write(new string(c, bodyWidth));
        Console.Write(new string(' ', 1));
        Console.WriteLine(new string(c, 2));

        Console.Write(new string(' ', 1));
        Console.WriteLine(new string(c, bodyWidth + 1));
    }
}
