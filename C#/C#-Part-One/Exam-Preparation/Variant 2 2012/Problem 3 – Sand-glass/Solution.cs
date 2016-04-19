using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outterDots = 0,
            stars = n;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', outterDots));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('.', outterDots));

            if (stars > 1 && i < n / 2)
            {
                outterDots++;
                stars -= 2;
            }
            else
            {
                outterDots--;
                stars += 2;
            }
        }
    }
}
