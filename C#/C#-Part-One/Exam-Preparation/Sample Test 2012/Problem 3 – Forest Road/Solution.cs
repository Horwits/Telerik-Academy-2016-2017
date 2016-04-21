using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = n - 1,
            firstDots = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', firstDots));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', dots));
            dots--;
            firstDots++;
        }

        dots = 1;
        firstDots = n - 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', firstDots));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', dots));
            dots++;
            firstDots--;
        }
    }
}
