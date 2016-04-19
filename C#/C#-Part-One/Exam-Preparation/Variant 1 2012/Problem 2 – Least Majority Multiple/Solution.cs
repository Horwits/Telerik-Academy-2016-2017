using System;

class Solution
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        int product = a * b * c + d + e;

        for (int i = 1; i <= product; i++)
        {
            int counter = 0;

            if (i % a == 0)
            {
                counter++;
            }

            if (i % b == 0)
            {
                counter++;
            }

            if (i % c == 0)
            {
                counter++;
            }

            if (i % d == 0)
            {
                counter++;
            }

            if (i % e == 0)
            {
                counter++;
            }

            if (counter >= 3)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
