using System;

class BiggestNumberFinder
{
    static void Main()
    {
        /*Write a program that finds the biggest of five numbers by using only five if statements.*/

        double a = double.Parse(Console.ReadLine()),
            b = double.Parse(Console.ReadLine()),
            c = double.Parse(Console.ReadLine()),
            d = double.Parse(Console.ReadLine()),
            e = double.Parse(Console.ReadLine());

        Console.WriteLine
            (
                "{0}",
                GetBiggerNumber(a, b, c, d, e)
            );
    }

    static double GetBiggerNumber(double a, double b, double c, double d, double e)
    {
        double biggest = 0;
        if (a > b && a > c && a > d && a > e)
        {
            biggest = a;
        }
        else if (b > a && b > c && b > d && b > e)
        {
            biggest = b;
        }
        else if (c > a && c > b && c > d && c > e)
        {
            biggest = c;
        }
        else if (d > a && d > b && d > c && d > e)
        {
            biggest = d;
        }
        else
        {
            biggest = e;
        }

        return biggest;
    }
}
