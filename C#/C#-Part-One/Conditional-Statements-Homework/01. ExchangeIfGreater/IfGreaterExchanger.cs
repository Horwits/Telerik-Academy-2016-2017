using System;

class IfGreaterExchanger
{
    static void Main()
    {
        /*Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values if the first one is greater than the second one. Use an if-statement. As a result print the values of the variables A and B, separated by a space.*/

        double a = double.Parse(Console.ReadLine()),
            b = double.Parse(Console.ReadLine());

        ExchangeValues(a, b);
    }

    private static void ExchangeValues(double a, double b)
    {
        if (a > b)
        {
            a -= b;
            b += a;
            a = b - a;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}
