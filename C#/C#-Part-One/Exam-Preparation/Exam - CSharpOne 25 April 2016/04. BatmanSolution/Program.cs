using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char c = Console.ReadLine()[0];

        int innerEmptySpace = n,
            wingsHeight = n - 2,
            wingsLength = n,
            emptyPartWings = 0;

        while (wingsHeight > 1)
        {
            Console.Write(new string(' ', emptyPartWings));
            Console.Write(new string(c, wingsLength));
            Console.Write(new string(' ', innerEmptySpace));
            Console.Write(new string(c, wingsLength));
            Console.WriteLine(new string(' ', emptyPartWings));

            wingsHeight -= 2;
            emptyPartWings++;
            wingsLength--;
        }

        int innerEmptyPartBody = (n - 3) / 2;

        Console.Write(new string(' ', emptyPartWings));
        Console.Write(new string(c, wingsLength));
        Console.Write(new string(' ', innerEmptyPartBody));
        Console.Write(new string(c, 1));
        Console.Write(new string(' ', 1));
        Console.Write(new string(c, 1));
        Console.Write(new string(' ', innerEmptyPartBody));
        Console.Write(new string(c, wingsLength));
        Console.WriteLine(new string(' ', emptyPartWings));

        int bodyHeight = n / 3;
        for (int i = 0; i < bodyHeight; i++)
        {
            Console.Write(new string(' ', emptyPartWings));
            Console.Write(new string(c, n * 2 + 1));
            Console.WriteLine(new string(' ', emptyPartWings));
        }

        int tail = n - 2,
            emptyPartTail = n + 1;
        while (tail > 0)
        {
            Console.Write(new string(' ', emptyPartTail));
            Console.Write(new string(c, tail));
            Console.WriteLine(new string(' ', emptyPartTail));

            tail -= 2;
            emptyPartTail++;
        }
    }
}
