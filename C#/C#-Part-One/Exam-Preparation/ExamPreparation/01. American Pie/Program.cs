using System;

class Program
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());

        ulong nominator = (ulong)((a * d) + (b * c));
        decimal denominator = (b * d);

        decimal fraction = (nominator / denominator);
        if (fraction < 1)
        {
            Console.WriteLine("{0:f20}", fraction);
            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
        else
        {
            Console.WriteLine("{0}", (ulong)fraction);
            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}
