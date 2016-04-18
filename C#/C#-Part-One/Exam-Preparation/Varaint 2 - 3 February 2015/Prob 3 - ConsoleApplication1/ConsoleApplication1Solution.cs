using System;
using System.Numerics;

class ConsoleApplication1Solution
{
    static void Main()
    {
        int counter = 0;

        BigInteger productTillTen = 1,
            productAfterTen = 1;

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "END")
            {
                if (counter <= 10)
                {
                    Console.WriteLine(productTillTen);
                }
                else
                {
                    Console.WriteLine(productTillTen);
                    Console.WriteLine(productAfterTen);
                }

                break;
            }

            if (counter % 2 == 1)
            {
                long product = 1;

                if (counter <= 10)
                {
                    foreach (var digit in input)
                    {
                        if (char.IsDigit(digit) && digit != '0')
                        {
                            product *= digit - '0';
                        }
                    }

                    productTillTen *= product;
                }
                else
                {
                    foreach (var digit in input)
                    {
                        if (char.IsDigit(digit) && digit != '0')
                        {
                            product *= digit - '0';
                        }
                    }

                    productAfterTen *= product;
                }
            }

            counter++;
        }
    }
}
