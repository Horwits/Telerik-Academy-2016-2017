using System;
using System.Numerics;

class ThreeSixNine
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());

        if (a < 0)
        {
            a *= (-1);
        }

        if (b < 0)
        {
            b *= (-1);
        }

        if (c < 0)
        {
            c *= (-1);
        }

        BigInteger result = 0;
        if (b == 3)
        {
            result = a + c;
        }
        else if (b == 6)
        {
            result = (a * c);
        }
        else
        {
            result = a % c;
        }

        BigInteger divided = 0;
        if (result % 3 == 0)
        {
            divided = result / 3;
        }
        else
        {
            divided = result % 3;
        }

        Console.WriteLine(divided);
        Console.WriteLine(result);
    }
}
