using System;

class Number
{
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (b > a)
        {
            return b;
        }

        return a;
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ');

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        if (a == GetMax(a, b))
        {
            Console.WriteLine(GetMax(a, c));
        }
        else if (b == GetMax(a, b))
        {
            Console.WriteLine(GetMax(b, c));
        }
    }
}
