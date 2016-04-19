using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstDots = n,
            width = 2 * n,
            middleDots = n - 1,
            height = (n + 1) - 2;

        //firstRow 

        Console.Write(new string('.', firstDots));
        Console.WriteLine(new string('*', n));

        //middle
        firstDots--;

        for (int i = 0; i < height; i++)
        {
            Console.Write(new string('.', firstDots));
            Console.Write(new string('*', 1));
            Console.Write(new string('.', middleDots));
            Console.WriteLine(new string('*', 1));

            firstDots--;
            middleDots++;
        }

        //lastRow
        Console.WriteLine(new string('*', width));
    }
}
