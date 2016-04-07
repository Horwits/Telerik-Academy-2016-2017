using System;
using System.Numerics;

class Maslan
{
    static void Main()
    {
        string numberToString = Console.ReadLine();

        int length = numberToString.Length,
            transformations = 0;

        long sum = 0;
        BigInteger product = 1;
        while (true)
        {
            while (length > 1)
            {
                length--;

                for (int i = 0; i < length; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum += numberToString[i] - '0';
                    }
                }

                if (sum != 0)
                {
                    product *= sum;
                }

                sum = 0;
            }

            transformations++;

            if (transformations == 10)
            {
                Console.WriteLine(product);
                break;
            }

            if (length == 1)
            {
                if (product < 10)
                {
                    Console.WriteLine(transformations);
                    Console.WriteLine(product);
                    break;
                }
                else
                {
                    numberToString = product.ToString();
                    length = numberToString.Length;
                    product = 1;
                }
            }
        }
    }
}
