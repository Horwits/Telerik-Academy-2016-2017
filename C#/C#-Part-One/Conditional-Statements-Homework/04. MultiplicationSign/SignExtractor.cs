using System;

class SignExtractor
{
    static void Main()
    {
        /*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Use a sequence of if operators.*/

        double a = double.Parse(Console.ReadLine()),
            b = double.Parse(Console.ReadLine()),
            c = double.Parse(Console.ReadLine());

        Console.WriteLine(ExtractSign(a, b, c));
    }

    static char ExtractSign(double a, double b, double c)
    {
        char sign = default(char);
        if (a == 0 || b == 0 || c == 0)
        {
            sign = '0';
        }
        else if (a > 0 && b > 0 && c > 0)
        {
            sign = '+';
        }
        else if (a < 0 && b < 0 && c > 0 || a < 0 && b > 0 && c < 0 || a > 0 && b < 0 && c < 0)
        {
            sign = '+';
        }
        else if (a < 0 && b > 0 && c > 0 || a > 0 && b < 0 && c > 0 || a > 0 && b > 0 && c < 0)
        {
            sign = '-';
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            sign = '-';
        }

        return sign;
    }
}
