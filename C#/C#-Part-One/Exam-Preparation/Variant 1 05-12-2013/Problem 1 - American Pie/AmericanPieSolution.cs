using System;

class AmericanPieSolution
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());

        double result = ((a * d) / (b * d) + (b * c) / (b * d));

        double resultNominator = (a * d) + (b * c),
            resultDenominator = b * d;

        if (result < 1)
        {
            Console.WriteLine("{0:f20}", result);
        }
        else
        {
            Console.WriteLine((int)result);
        }

        Console.WriteLine("{0}/{1}", resultNominator, resultDenominator);
    }
}
