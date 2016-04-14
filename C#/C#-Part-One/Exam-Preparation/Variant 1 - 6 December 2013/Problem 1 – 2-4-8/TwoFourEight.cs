using System;

class TwoFourEight
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long secretCode = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long result = 0;
        if (secretCode == 2)
        {
            result = a % c;
        }
        else if (secretCode == 4)
        {
            result = a + c;
        }
        else if (secretCode == 8)
        {
            result = a * c;
        }

        long remainder = result % 4 == 0 ? result / 4 : result % 4;

        Console.WriteLine(remainder);
        Console.WriteLine(result);
    }
}
