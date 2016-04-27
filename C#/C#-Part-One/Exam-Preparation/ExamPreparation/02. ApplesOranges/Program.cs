using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        if (n < 0)
        {
            n *= -1;
        }

        int evenSum = 0,
            oddSum = 0;
        while (n > 0)
        {
            int digit = (int)(n % 10);

            if (digit % 2 == 0)
            {
                evenSum += digit;
            }
            else
            {
                oddSum += digit;
            }
            n /= 10;
        }

        if (evenSum > oddSum)
        {
            Console.WriteLine("apples {0}", evenSum);
        }
        else if (oddSum > evenSum)
        {
            Console.WriteLine("oranges {0}", oddSum);
        }
        else
        {
            Console.WriteLine("both {0}", evenSum);
        }
    }
}
