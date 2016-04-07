using System;
using System.Numerics;

class PieceOfCake
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());

        decimal resultFraction = (a / b) + (c / d);
        bool hasFullCake = resultFraction >= 1;

        BigInteger resultNominator = (BigInteger)((a * d) + (c * b));
        BigInteger resultDenominator = (BigInteger)(b * d);
        if (hasFullCake)
        {
            Console.WriteLine((BigInteger)resultFraction);
        }
        else
        {
            Console.WriteLine("{0:f22}", resultFraction);
        }

        Console.WriteLine("{0}/{1}", resultNominator, resultDenominator);
    }
}
