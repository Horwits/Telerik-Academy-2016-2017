using System;

class Program
{
    static void Main()
    {
        short k = short.Parse(Console.ReadLine());

        if (k % 10 == 6 && k < 666 && k % 100 != 66)
        {
            k += 4;
        }
        else if (k % 100 == 66 && k < 666)
        {
            k += 34;
        }
        else if (k > 10 && k % 10 == 6 && k < 66)
        {
            k += 4;
        }
        else if (k == 666)
        {
            k = 1000;
        }
        else
        {
            k += 1;
        }

        Console.WriteLine(k);
    }
}
