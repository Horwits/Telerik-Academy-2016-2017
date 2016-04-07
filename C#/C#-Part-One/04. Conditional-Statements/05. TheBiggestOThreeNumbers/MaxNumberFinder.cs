using System;

class MaxNumberFinder
{
    static void Main()
    {
        /*Write a program that finds the biggest of three numbers.*/

        double a = double.Parse(Console.ReadLine()),
            b = double.Parse(Console.ReadLine()),
            c = double.Parse(Console.ReadLine());

        Console.WriteLine(
            "{0}",
            ReturnMaxNumber(a, b, c)
            );
    }

    static double ReturnMaxNumber(double a, double b, double c)
    {
        double max = 0;

        if (a > b && a > c)
        {
            max = a;
        }
        else if (a < b && b > c)
        {
            max = b;
        }
        else
        {
            max = c;
        }

        return max;
    }
}
