using System;

class PieceOfCake
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());

        decimal resultNominator = ((a * d) + (c * b));
        decimal resultDenominator = (b * d);

        decimal resultFraction = (resultNominator / resultDenominator);

        bool hasFullCake = resultFraction >= 1;
        if (hasFullCake)
        {
            Console.WriteLine((int)resultFraction);
        }
        else
        {
            Console.WriteLine("{0:f22}", resultFraction);
        }

        Console.WriteLine("{0}/{1}", resultNominator, resultDenominator);
    }
}
